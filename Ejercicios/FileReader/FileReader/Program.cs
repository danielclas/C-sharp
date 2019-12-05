using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Net.Mail;
using System.Reflection;

namespace FileReader
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Original format: 2019-10-15 13:27:23.160
            //Character count: 23

            Console.WriteLine("\nCreando excel..");
            #region Variables
            string[] clipboardLines = Clipboard.GetText().Split('\n');

            DateTime date;

            int today = DateParser.Today7AM.Day, todayMonth = DateParser.Today7AM.Month;
            int yesterday = DateParser.Yesterday7AM.Day, yesterdayMonth = DateParser.Yesterday7AM.Month;

            int length, from, totalRows;
            string dateLine, fileName, dateString, username, responseTime;

            List<string> excelLines = new List<string>();
            List<string> dates = new List<string>();
            List<string[]> cellData = new List<string[]>();

            StringBuilder sender;
            string subject, recipients, mailto, body, cc;
            #endregion

            #region Read and format
            foreach (string line in clipboardLines)
            {
                if (line.Length > 22)
                {
                    //Corresponds to the date segment of the original string
                    //"From" is used to control for the length of the BotLogID
                    from = line.IndexOf('\t') + 1;
                    dateLine = line.Substring(from, 23);

                    date = DateParser.DateFromString(dateLine);
                    date = date.Subtract(TimeSpan.FromHours(6));

                    //After the 5 hours have been substracted, checks whether it is in the desired timeframe              
                    dateString = DateParser.ContainedInTimeframe(date) ? DateParser.FormatString(date) : String.Empty;

                    dates.Add(dateString);
                }
            }

            length = dates[0].Length;
            for (int i = 0; i < clipboardLines.Length; i++)
            {
                //Each clipboardLine corresponds to a date in the same index
                if (i < dates.Count && !(String.IsNullOrEmpty(dates[i])))
                {
                    //New date is inserted, and the original removed
                    StringBuilder excelLine = new StringBuilder(clipboardLines[i]);

                    from = clipboardLines[i].IndexOf('\t') + 1;
                    excelLine.Insert(from, dates[i]);
                    excelLine.Remove(from + length, 24);

                    excelLines.Add(excelLine.ToString());
                }
            }

            //Gets user and removes \DIR from string returned
            username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = username.Substring(4);

            fileName = String.Format("Feedback for {0:M d y}", DateTime.Now);
            fileName = ($"C:\\Users\\{username}\\Desktop\\{fileName}.xlsx");

            foreach (string line in excelLines)
            {
                cellData.Add(line.Split('\t'));
            }
            #endregion

            #region Excel
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Worksheet1");

                var headerRow = new List<string[]>()
                {
                   new string[] { "BotLogId", "TimeStamp", "ConversationId", "UserId",
                        "ActivityId","Intent","IntentScore","Query", "Response","Feedback_Thumbs",
                        "Feedback_Category","Feedback_FreeForm","Country/Location","CareerLevel","OrgLevel2","ResponseTime"}
                };

                //Determine the header range (e.g.A1:D1)
                string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

                // Target a worksheet
                var worksheet = excel.Workbook.Worksheets["Worksheet1"];

                //Populates header row
                worksheet.Cells[headerRange].LoadFromArrays(headerRow);

                //Populates cells with data 
                worksheet.Cells[2, 1].LoadFromArrays(cellData);

                //Adds table to the worksheet including header and data rows
                worksheet.Tables.Add(new ExcelAddressBase(1, 1, cellData.Count + 1, 16), "Table1");

                totalRows = cellData.Count+1;

                for (int row = 2; row <= totalRows; row++)
                {
                    responseTime = worksheet.Cells[row, 16].Text;
                    //Response time value from database can sometimes be NULL
                    if (responseTime != "NULL\r")
                    {
                        worksheet.Cells[row, 16].Style.Numberformat.Format = "@";
                        worksheet.Cells[row, 16].Value = DateParser.FormatResponseTime(responseTime);
                    }
                }

                for (int i = 1; i < 17; i++)
                {
                    worksheet.Column(i).Width = 20;
                }

                worksheet.Cells.Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                excel.SaveAs(new FileInfo(fileName));
            }
            #endregion

            #region Mailer
            //Gets first name of user and capitalizes first letter
            sender = new StringBuilder(username.Substring(0, username.IndexOf('.')));
            sender.Replace(sender[0].ToString(), sender[0].ToString().ToUpper());

            recipients = "alejandra.b.lucero@accenture.com;ron.stempkowski@accenture.com;m.vazquez.ferrante@accenture.com";

            cc = "CIO.ContentApps.OpsDelivery.Dev@accenture.com";

            subject = $"Feedback for {today}/{todayMonth}";

            body = "Hi team,%0A%0A";
            body += $"Attached is feedback from [{yesterdayMonth}/{yesterday} 07:00AM CST] to [{todayMonth}/{today} 07:00AM CST]%0A%0A";
            body += "Best regards,%0A";
            body += $"{sender}.";

            mailto = string.Format($"mailto:{recipients}?cc={cc}&Subject={subject}&body={body}");
            #endregion

            System.Diagnostics.Process.Start(mailto);
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
