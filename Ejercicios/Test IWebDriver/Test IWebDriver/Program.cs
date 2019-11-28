using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Windows;
using System.Windows.Forms;


namespace Test_IWebDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            IWebDriver _driver;
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(Clipboard.GetText());
            string pageSource = _driver.PageSource;
            File.WriteAllLines(desktop+"\\html.txt", new string []{ pageSource });
            _driver.Close();
        }
    }
}
