using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
            string fileName, dateString;
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

            //newLines is reused to write to clipboard
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

            fileName = String.Format("Feedback for {0:M d y}", DateTime.Now);
            fileName = ($"C:\\Users\\Public\\Documents\\{fileName}.xlsx");
            File.Copy("C:\\Users\\Public\\Documents\\template.xlsx", fileName);

            StringBuilder clipboard = new StringBuilder();

            foreach (string line in newLines)
            {
                clipboard.Append(line);
            }

            Clipboard.SetText(clipboard.ToString());
            System.Diagnostics.Process.Start(fileName);
        }
    }
}
