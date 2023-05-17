using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace SeleniumTestsWithoutPOM
{
    [TestFixture]
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
            driver.Navigate().GoToUrl("https://store.dji.com/lt");

            // TC001.01: Click the Search icon
            IWebElement searchIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='nav']/div[3]/div[1]/div[2]/div[2]/button[1]")));
            searchIcon.Click();

            // TC001.02: Send the Keys "DJI Mini 3" on the search window
            IWebElement searchInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[contains(@class, 'header-search-input')]")));
            searchInput.Clear();
            searchInput.SendKeys("DJI Mini 3");

            // TC001.03: Look for Item "DJI Mini 3" and click the first item link
            IWebElement mini3Link = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//ul[@role='listbox']//span[contains(text(), 'DJI Mini 3')]")));
            mini3Link.Click();

            // TC001.04: Verify that the relevant and containing "DJI Mini 3" product page was opened
            IWebElement productTitle = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[contains(@id, 'anchorVersion')]")));
            string actualProductTitle = productTitle.Text;

            Assert.IsTrue(actualProductTitle.Contains("DJI Mini 3"), "Product page does not contain the searched product: DJI Mini 3");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
