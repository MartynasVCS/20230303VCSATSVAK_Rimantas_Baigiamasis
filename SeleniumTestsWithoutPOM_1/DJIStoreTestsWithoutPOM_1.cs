using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumTestsWithoutPOM
{
    public class DJIStoreTestsWithoutPOM
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            driver.Navigate().GoToUrl("https://store.dji.com/lt");
        }

        [Test]
        public void TS001_SearchAndAddProductToCart()
        {
            // TC001.01: Click the Search icon
            IWebElement searchIcon = driver.FindElement(By.XPath("//*[@id='nav']/div[1]/div[2]/nav/div/div[3]/div[1]/button[1]"));
            searchIcon.Click();

            // TC001.02: Select "DJI Mini 3" from drop-down menu
            IWebElement searchInput = driver.FindElement(By.XPath("//*[@id='nav']/div[1]/div[2]/nav/div/div[3]/div[2]/div/div/input"));
            searchInput.Clear();
            searchInput.Click();

            IWebElement selectDJI3Mini = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//ul[@role='listbox']//span[contains(text(), 'DJI Mini 3')]")));
            selectDJI3Mini.Click();

            // TC001.03: Verify that the relevant and containing "DJI Mini 3" product page was opened
            IWebElement productTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='anchorVersion']/h1")));
            string actualProductTitle = productTitle.Text;

            Assert.IsTrue(actualProductTitle.Contains("DJI Mini 3"), "Product page does not contain the searched product: DJI Mini 3");
        }

        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit();
        //}
    }
}
