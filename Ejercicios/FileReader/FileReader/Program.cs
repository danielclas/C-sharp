using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace FileReader
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Original format: 2019-10-15 13:27:23.160
            //Character count: 23

            string[] clipboardLines = Clipboard.GetText().Split('\n');

            DateTime date;
            DateTime today8AM=DateParser.Today8AM;
            DateTime yesterday8AM=DateParser.Yesterday8AM;           

            int length, from;
            string fileName, dateString, username, template;
            List<string> newLines = new List<string>();
            List<string> dates = new List<string>();

            foreach (string line in clipboardLines)
            {
                if (line.Length > 22)
                {
                    //Corresponds to the date segment of the original string
                    //From is used to control for the length of the BotLogID
                    from = line.IndexOf('\t')+1;
                    newLines.Add(line.Substring(from, 23));
                }
            }

            foreach (string newLine in newLines)
            {
                date = DateParser.DateFromString(newLine);
                date = date.Subtract(TimeSpan.FromHours(5));

                //After the 5 hours have been substracted, checks whether it's in the desired timeframe              
                dateString = DateParser.ContainedInTimeframe(date) ? DateParser.FormatString(date): String.Empty;
                dates.Add(dateString);                
            }

            //newLines is reused to write to excel
            newLines = new List<string>();
            length = dates[0].Length;

            for (int i = 0; i < clipboardLines.Length; i++)
            {
                //Each clipboardLine corresponds to a date in the same index
                if (i < dates.Count && !(String.IsNullOrEmpty(dates[i])))
                {
                    //New date is inserted, and the original removed
                    StringBuilder str = new StringBuilder(clipboardLines[i]);
                    from = clipboardLines[i].IndexOf('\t')+1;                    
                    str.Insert(from, dates[i]);
                    str.Remove(from + length, 24);
                    newLines.Add(str.ToString());
                }
            }

            username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = username.Substring(4);
            template = ($"C:\\Users\\{username}\\Desktop\\template.xlsx");
            fileName = String.Format("Feedback for {0:M d y}", DateTime.Now);
            fileName = ($"C:\\Users\\{username}\\Desktop\\{fileName}.xlsx");

            List<string[]> cellData = new List<string[]>();

            foreach (string line in newLines)
            {
                cellData.Add(line.Split('\t'));
            }

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
                worksheet.Tables.Add(new ExcelAddressBase(1, 1, cellData.Count+1, 16), "Table1");

                for (int i = 1; i < 17; i++)
                {
                    worksheet.Column(i).Width = 20;
                }
              
                excel.SaveAs(new FileInfo(fileName));
            }

            System.Diagnostics.Process.Start(fileName);
        }
    }
}
