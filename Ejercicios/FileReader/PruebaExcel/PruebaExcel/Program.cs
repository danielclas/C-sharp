using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.IO;


namespace PruebaExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (ExcelPackage excel = new ExcelPackage())
            //{
            //    excel.Workbook.Worksheets.Add("Worksheet1");

            //    var headerRow = new List<string[]>()
            //    {
            //       new string[] { "ID", "First Name", "Last Name", "DOB" }
            //    };

            //    // Determine the header range (e.g. A1:D1)
            //    string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";

            //    // Target a worksheet
            //    var worksheet = excel.Workbook.Worksheets["Worksheet1"];

            //    // Popular header row data
            //    worksheet.Cells[headerRange].LoadFromArrays(headerRow);

            //    var cellData = new List<String[]>()
            //    {
            //      new String[] {"0", "0", "0", "1"},
            //      new String[] { "10", " 7.32", "7.42,1"},
            //      new String[] { "20", "5.01"," 5.24,1"},
            //      new String[] { "30", "3.97"," 4.16,1"},
            //      new String[] { "40", "3.97"," 4.16,1"},
            //      new String[] { "50", "3.97", "4.16,1"},
            //      new String[] { "60", "3.97", "4.16,1"},
            //      new String[] { "70", "3.97", "4.16,1"},
            //      new String[] { "80", "3.97", "4.16,1"},
            //      new String[] { "90", "3.97", "4.16,1"},
            //      new String[] { "100", " 3.97", "4.16,1" }
            //    };

            //    worksheet.Cells[2, 1].LoadFromArrays(cellData.ToArray());

            //    FileInfo excelFile = new FileInfo(@"C:\Users\daniel.julio.clas\Desktop\test.xlsx");
            //    excel.SaveAs(excelFile);

            //    System.Diagnostics.Process.Start(excelFile.ToString());
            //}
            string username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username=username.Substring(4);
            string fileName = ($"C:\\Users\\{username}\\Desktop\\TEST.txt");
            File.Copy("C:\\Users\\Public\\Documents\\template.xlsx", fileName);
            Console.WriteLine(username);
            Console.ReadKey();

        }
    }
}
