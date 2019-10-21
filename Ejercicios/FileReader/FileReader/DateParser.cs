using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader
{
    public static class DateParser
    {
        static DateTime today8AM;
        static DateTime yesterday8AM;

        public static DateTime Today8AM { get { return DateParser.today8AM; } }
        public static DateTime Yesterday8AM { get { return DateParser.yesterday8AM; } }

        static DateParser()
        {
            DateParser.today8AM = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);

            if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
            {
                //Substracts 3 days so that "yesterday" represents last friday
                DateParser.yesterday8AM = today8AM.Subtract(TimeSpan.FromDays(3));
            }
            else
            {
                DateParser.yesterday8AM = today8AM.Subtract(TimeSpan.FromDays(1));
            }
        }

        public static DateTime DateFromString(string line)
        {
            int year, month, day, hour, minute, seconds, fraction;

            //Original format: 2019-10-15 13:27:23.160
            //Character count: 23
            //Each substring corresponds to a part of the date
            year = int.Parse(line.Substring(0, 4));
            month = int.Parse(line.Substring(5, 2));
            day = int.Parse(line.Substring(8, 2));

            hour = int.Parse(line.Substring(11, 2));
            minute = int.Parse(line.Substring(14, 2));
            seconds = int.Parse(line.Substring(17, 2));
            fraction = int.Parse(line.Substring(20, 3));

            return new DateTime(year, month, day, hour, minute, seconds, fraction);
        }

        public static bool ContainedInTimeframe(DateTime date)
        {
            return (date >= DateParser.yesterday8AM && date <= DateParser.today8AM);
        }

        public static string FormatString(DateTime date)
        {
            //Format: 10/15/19 8:19 PM
            //Character count: 19
            //Used for AM or PM
            string time = String.Format("{0:H:mm t}m", date);
            time = time.ToUpper();

            string spaces = time.Length == 7 ? "  " : " ";

            return String.Format("{0:M/d/y} {1}{2}\t", date, time, spaces);
        }

        public static string FormatResponseTime(string time)
        {
            //Original format: 00:00:01.8633333
            string subString = time.Substring(time.LastIndexOf(':') + 1);
            subString = subString.Trim('\r');
            subString = subString.Replace('.', ',');

            double formattedTime = double.Parse(subString);

            formattedTime = Math.Round(formattedTime, 1);

            return formattedTime.ToString();
        }
    }
}
