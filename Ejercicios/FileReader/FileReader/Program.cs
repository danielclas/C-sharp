using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //2019-10-15 13:27:23.160
            //Character count: 23

            string path = "C:\\Users\\daniel.julio.clas\\Desktop\\text.txt";
            string[] lines = File.ReadAllLines(path);

            DateTime date;
            int year, month, day, hour, minute, seconds, fraction, length;
            string time, fileName, spaces;
            List<string> newLines = new List<string>();
            List<string> dates = new List<string>();            

            foreach (string line in lines)
            {
                if (line.Length>6)
                {
                    newLines.Add(line.Substring(6, 23));
                }
            }

            foreach (string newLine in newLines)
            {
                year=int.Parse(newLine.Substring(0,4));
                month=int.Parse(newLine.Substring(5,2));
                day=int.Parse(newLine.Substring(8,2));

                hour=int.Parse(newLine.Substring(11, 2));
                minute=int.Parse(newLine.Substring(14, 2));
                seconds=int.Parse(newLine.Substring(17, 2));
                fraction=int.Parse(newLine.Substring(20, 3));

                date = new DateTime(year, month, day, hour, minute, seconds, fraction);
                date = date.Subtract(TimeSpan.FromHours(5));

                //Used for AM or PM
                time = String.Format("{0:H:mm t}m", date);
                time = time.ToUpper();

                spaces = time.Length == 7 ? "  ":" ";

                dates.Add(String.Format("{0:M/d/y} {1}{2}  ", date, time, spaces));
                //Character count: 19
            }

            newLines = new List<string>();
            length = dates[0].Length;
            
            for (int i = 0; i < lines.Length; i++)
            {
                StringBuilder str = new StringBuilder(lines[i]);
                str.Insert(6, dates[i]);
                str.Remove(6+length, 24);
                newLines.Add(str.ToString());
            }

            fileName = String.Format("Feedback for {0:M d y}", DateTime.Now);            
            File.WriteAllLines($"C:\\Users\\daniel.julio.clas\\Desktop\\{fileName}.txt", newLines);

            if (lines.Length==newLines.Count && newLines.Count==dates.Count)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Archivo leido y creado correctamente");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El archivo no pudo ser leido correctamente");
            }
            
            Console.ReadLine();
        }
    }
}
