using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFramework
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--user-data-dir=C:\\Users\\Rimas\\AppData\\Local\\Temp\\scoped_dir29120_2073148784");
            options.AddArgument("--user-profile-directory=Profile 1");
            driver = new ChromeDriver(options);
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

   
        //public static string TakeScreenshot(string methodName)
        //{
        //    string screenshotDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}Screenshots";
        //    string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}-screenshot.png";
        //    string screenshotFilePath = $"{screenshotDirectoryPath}\\{screenshotName}";

        //    Directory.CreateDirectory(screenshotDirectoryPath);
        //    Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
        //    screenshot.SaveAsFile($"{screenshotFilePath}", ScreenshotImageFormat.Png);

        //    return screenshotFilePath;
        //}
    }
}
