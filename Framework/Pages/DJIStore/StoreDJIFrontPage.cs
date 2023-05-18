using OpenQA.Selenium;
using SeleniumFramework.Pages.DJIStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages.DJI_store
{
    public class StoreDJIFrontPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://store.dji.com/lt");
        }
       
        public static void ClickYourCountryRegionSelectionButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.countryRegionSelectionButton);
        }

        public static void ClickSelectYourRegionLatviaSelectionButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.regionLatviaSelectionButton); 
        }

        public static string SelectedCountryRegionLatvia()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.countryRegionSelectionButton);
        }

        public static bool WaitForRegionSelectionButtonBeEnabled()
        {
            return Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.countryRegionSelectionButton);
        }

        public static bool WaitForAcceptAllButtonBeVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.StoreDJIFrontPage.cookyAcceptAllButton);
        }

        public static void ClickAcceptAllButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.cookyAcceptAllButton);
        }

        public static bool WaitForAcceptAllButtonBeEnabled()
        {
            return Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.cookyAcceptAllButton);
        }

        //public static void ScrollUntilElementIsClickableInPopUp()
        //{
        //    Common.ScrollUntilElementIsClickableInPopUp(Locators.StoreDJIFrontPage.regionLatviaSelectionButton);
        //}

        //public static void EnterMessage(string message)
        //{
        //    string locator = "";
        //    Common.SendKeys(locator, message);
        //}

        //public static void SelectColorInOldStyleMenu(string expectedColor)
        //{
        //    Common.SelectOptionByText(Locators.SelectMenu.selectOldStyleMenu, expectedColor);
        //}

        //public static string GetSelectedColorInOldStyleMenu()
        //{
        //    return Common.GetSelectedOption(Locators.SelectMenu.selectOldStyleMenu);
        //}

        //public static void SelectTitleInSelectOneMenu(string expectedTitle)
        //{
        //    Common.Click(Locators.SelectMenu.selectSelectOneMenu);
        //    Common.Click($"//*[contains(@id, 'react-select') and contains(text(),'{expectedTitle}')]");
        //}

        //public static string GetSelectedTitleInSelectOneMenu()
        //{
        //    return Common.GetElementText(Locators.SelectMenu.selectSelectOneMenu);
        //}
    }
}
