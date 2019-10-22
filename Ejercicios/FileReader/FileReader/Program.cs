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

            #region Variables
            string[] clipboardLines = Clipboard.GetText().Split('\n');

            DateTime date;
            DateTime today8AM = DateParser.Today8AM;
            DateTime yesterday8AM = DateParser.Yesterday8AM;

            int today = today8AM.Day, todayMonth = today8AM.Month;
            int yesterday = yesterday8AM.Day, yesterdayMonth = yesterday8AM.Month;

            int length, from;
            string fileName, dateString, username;
            List<string> newLines = new List<string>();
            List<string> dateLines = new List<string>();
            List<string> dates = new List<string>();
            List<string> responseTimes = new List<string>();

            StringBuilder sender;
            string subject, recipients, mailto, body, cc;
            string responseTime;
            #endregion

            foreach (string line in clipboardLines)
            {
                if (line.Length > 22)
                {
                    //Corresponds to the date segment of the original string
                    //From is used to control for the length of the BotLogID
                    from = line.IndexOf('\t') + 1;
                    dateLines.Add(line.Substring(from, 23));

                    responseTime = line.Substring(line.LastIndexOf('\t'));
                    if (responseTime != "\tNULL\r")
                    {
                        responseTime = DateParser.FormatResponseTime(responseTime);

                        if (responseTime.Contains(','))
                        {
                            responseTime = responseTime.Replace(',', '.');
                            if (responseTime.IndexOf('.') == 1)
                            {
                                responseTime = "0" + responseTime;
                            }
                        }
                        else
                        {
                            responseTime = responseTime + ".0";
                            if (responseTime.IndexOf('.') == 1)
                            {
                                responseTime = "0" + responseTime;
                            }
                        }
                    }
                    else
                    {
                        responseTime = "NULL\r";
                    }

                    responseTimes.Add(responseTime);
                }
            }

            foreach (string line in dateLines)
            {
                date = DateParser.DateFromString(line);
                date = date.Subtract(TimeSpan.FromHours(5));

                //After the 5 hours have been substracted, checks whether it is in the desired timeframe              
                dateString = DateParser.ContainedInTimeframe(date) ? DateParser.FormatString(date) : String.Empty;

                dates.Add(dateString);
            }

            //newLines is used to write to excel
            newLines = new List<string>();
            length = dates[0].Length;

            for (int i = 0; i < clipboardLines.Length; i++)
            {
                string add;
                //Each clipboardLine corresponds to a date in the same index
                if (i < dates.Count && !(String.IsNullOrEmpty(dates[i])))
                {
                    //New date is inserted, and the original removed
                    StringBuilder str = new StringBuilder(clipboardLines[i]);

                    from = clipboardLines[i].IndexOf('\t') + 1;
                    str.Insert(from, dates[i]);
                    str.Remove(from + length, 24);

                    add = str.ToString();
                    add = add.Remove(add.LastIndexOf('\t') + 1);
                    add += responseTimes[i];

                    newLines.Add(add);
                }
            }

            //Gets user and removes \DIR from string returned
            username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = username.Substring(4);

            fileName = String.Format("Feedback for {0:M d y}", DateTime.Now);
            fileName = ($"C:\\Users\\{username}\\Desktop\\{fileName}.xlsx");

            List<string[]> cellData = new List<string[]>();

            foreach (string line in newLines)
            {
                cellData.Add(line.Split('\t'));
            }

            #region Excel
            using (ExcelPackage excel = new ExcelPackage())
            {
                excel.Workbook.Worksheets.Add("Worksheet1");

                var headerRow = new List<string[]>()
                {
                   new string[] { "BotLogId", "TimeStamp", "ConversationId", "UserId",
                        "ActivityId","Intent","IntentScore","Query", "Response","Feedback_Thumbs",
                        "Feedback_Category","Feedback_FreeForm","Country","CareerLevel","OrgLevel2","ResponseTime"}
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

            cc = "emanuel.e.sanchez@accenture.com;max.morillo.alvarado@accenture.com;natalia.e.gonzalez@accenture.com";

            subject = $"Feedback for {today}/{todayMonth}";

            body = "Hi team,%0A%0A";
            body += ($"Attached is feedback from [{yesterdayMonth}/{yesterday} 08:00AM CST] to [{todayMonth}/{today} 08:00AM CST]%0A%0A");
            body += ("Best regards,%0A");
            body += ($"{sender}.");

            mailto = string.Format($"mailto:{recipients}?cc={cc}&Subject={subject}&body={body}");
            #endregion

            System.Diagnostics.Process.Start(mailto);
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
