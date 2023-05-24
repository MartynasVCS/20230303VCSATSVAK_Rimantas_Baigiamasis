using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace SeleniumFramework.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return Driver.GetDriver().FindElements(By.XPath(locator)).ToList();
        }

        internal static void Click(string locator)
        {
            GetElement(locator).Click();
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static void SendKeys(string locator, string keys)
        {
            GetElement(locator).SendKeys(keys);
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void ScrollUntilElementIsClickable(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 20;
            int currentTry = 0;
            

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch (Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 200)");
                        currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }

        internal static void ScrollUntilElementIsClickableInPopUp(string locator)
        {
            IWebElement element = GetElement(locator);

            bool isClickable = false;
            int maxTries = 20;
            int currentTry = 0;
            IWebDriver driver = Driver.GetDriver();

            while (!isClickable)
            {
                try
                {
                    element.Click();
                    isClickable = true;
                }
                catch (Exception exception)
                {
                    if (exception is ElementClickInterceptedException && currentTry < maxTries)
                    {
                        // Switch focus to the pop-up window (assuming it's the most recently opened window)
                        driver.SwitchTo().Window(driver.WindowHandles.Last());

                        // Scroll within the pop-up window
                        driver.ExecuteJavaScript("window.scrollBy(0, 200)");

                        // Switch back to the main window
                        driver.SwitchTo().Window(driver.WindowHandles.First());

                        currentTry++;
                        //Driver.GetDriver().ExecuteJavaScript("window.scrollBy(0, 200)");
                        //currentTry++;
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }
        }
        internal static string GetElementCssAttributeValue(string locator, string attribute)
        {
            return GetElement(locator).GetCssValue(attribute);
        }

        internal static void WaitForElementCssAttributeValueToBe(string locator, string attributeName, string expectedAttributeValue)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(2));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);
            wait.Until(driver => driver.FindElement(By.XPath(locator)).GetCssValue(attributeName).Equals(expectedAttributeValue));
        }

        internal static void WaitForElementToNotContainText(string locator, string text)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.Until(driver => !driver.FindElement(By.XPath(locator)).Text.Contains(text));
        }

        internal static bool WaitForElementToBeEnabled(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(2000));
            return wait.Until(driver => driver.FindElement(By.XPath(locator)).Enabled);
        }

        internal static bool WaitForElementToBeVisible(string locator)
        {
            WebDriverWait wait = new WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(30));
            return wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator))).Displayed;

            // Alternatyva be ExpectedConditions
            //return wait.Until(driver => driver.FindElement(By.XPath(locator)).Displayed);
        }

        internal static void DoubleClick(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.DoubleClick(element);
            actions.Perform();
        }

        internal static void RightClick(string locator)
        {
            Actions actions = new Actions(Driver.GetDriver());
            IWebElement element = GetElement(locator);

            actions.ContextClick(element);
            actions.Perform();
        }

        internal static SelectElement GetSelectElement(string locator)
        {
            IWebElement element = GetElement(locator);
            return new SelectElement(element);
        }

        internal static void SelectOptionByText(string locator, string optionText)
        {
            SelectElement selectElement = GetSelectElement(locator);
            selectElement.SelectByText(optionText);
        }

        internal static string GetSelectedOption(string locator)
        {
            SelectElement selectElement = GetSelectElement(locator);
            return selectElement.SelectedOption.Text;
        }

        internal static string GetElementAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static List<bool> GetElementsCheckedStatusList(string locator)
        {
            List<bool> statuses = new List<bool>();

            List<IWebElement> elements = GetElements(locator);
            foreach (IWebElement element in elements)
            {
                statuses.Add(element.Selected);
            }

            return statuses;
        }

        internal static string GetAlertText()
        {
            return Driver.GetDriver().SwitchTo().Alert().Text;
        }

        internal static void AcceptAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Accept();
        }

        internal static bool CheckIfAlertIsActive()
        {
            try
            {
                Driver.GetDriver().SwitchTo().Alert();
            }
            catch (NoAlertPresentException)
            {
                return false;
            }

            return true;
        }

        internal static void SendKeysToAlert(string keys)
        {
            Driver.GetDriver().SwitchTo().Alert().SendKeys(keys);
        }

        internal static void DismissAlert()
        {
            Driver.GetDriver().SwitchTo().Alert().Dismiss();
        }

        internal static List<string> GetElementsTextList(string locator)
        {
            List<string> texts = new List<string>();

            List<IWebElement> elements = GetElements(locator);
            foreach (IWebElement element in elements)
            {
                texts.Add(element.Text);
            }

            return texts;
        }

        internal static async Task Wait()
        {
            await Task.Delay(2000); ;
        }
    }
}
