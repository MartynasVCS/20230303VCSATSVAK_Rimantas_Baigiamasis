using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
        }

        internal static IWebDriver GetDriver()
        {
            return driver;
        }
        public static void MaximizePage()
        {
            driver.Manage().Window.Maximize();
        }

        internal static void OpenPage(string url)
        {
            MaximizePage();
            driver.Url = url;
        }

        public static void ShutdownDriver()
        {
            driver.Quit();
        }
    }
}
