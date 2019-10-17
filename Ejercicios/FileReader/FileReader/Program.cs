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
            DateTime today8AM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
            DateTime yesterday8AM;

            if (DateTime.Now.DayOfWeek==DayOfWeek.Monday)
            {
                //Substracts 3 days so that "yesterday" represents last friday
                yesterday8AM = today8AM.Subtract(TimeSpan.FromDays(3));

            }
            else
            {
                yesterday8AM = today8AM.Subtract(TimeSpan.FromDays(1));
            }

            int year, month, day, hour, minute, seconds, fraction, length;
            string time, fileName, spaces, dateString;
            List<string> newLines = new List<string>();
            List<string> dates = new List<string>();

            foreach (string line in clipboardLines)
            {
                if (line.Length > 22)
                {
                    //Corresponds to the date segment of the original string
                    newLines.Add(line.Substring(6, 23));
                }
            }

            foreach (string newLine in newLines)
            {
                //Each substring corresponds to a part of the date
                //Params: Substring(startIndex, length)
                year = int.Parse(newLine.Substring(0, 4));
                month = int.Parse(newLine.Substring(5, 2));
                day = int.Parse(newLine.Substring(8, 2));

                hour = int.Parse(newLine.Substring(11, 2));
                minute = int.Parse(newLine.Substring(14, 2));
                seconds = int.Parse(newLine.Substring(17, 2));
                fraction = int.Parse(newLine.Substring(20, 3));

                date = new DateTime(year, month, day, hour, minute, seconds, fraction);
                date = date.Subtract(TimeSpan.FromHours(5));

                //After the 5 hours have been substracted, checks whether it's in the desired timeframe
                if (date>= yesterday8AM && date<=today8AM)
                {
                    //Used for AM or PM
                    time = String.Format("{0:H:mm t}m", date);
                    time = time.ToUpper();

                    spaces = time.Length == 7 ? "  " : " ";

                    dateString = String.Format("{0:M/d/y} {1}{2}\t", date, time, spaces);
                }
                else
                {
                    dateString = String.Empty;
                }
                
                dates.Add(dateString);
                //Character count: 19
            }

            //newLines is reused to write to clipboard
            newLines = new List<string>();
            length = dates[0].Length;

            for (int i = 0; i < clipboardLines.Length; i++)
            {
                //Each clipboardLine corresponds to a date in the same index
                if (i < dates.Count && !(String.IsNullOrEmpty(dates[i])))
                {
                    //La nueva fecha es insertada, y la original removida
                    StringBuilder str = new StringBuilder(clipboardLines[i]);
                    str.Insert(6, dates[i]);
                    str.Remove(6 + length, 24);
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
