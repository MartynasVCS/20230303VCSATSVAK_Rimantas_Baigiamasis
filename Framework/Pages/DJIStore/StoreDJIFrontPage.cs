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

        public static void ClickSearchButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.searchButton);
        }

        public static void EnterProductNameInSearchBox(string message)
        {
            Common.SendKeys(Locators.StoreDJIFrontPage.searchBar,message);
        }

        public static void ClickSearchIconInSearchBar()
        {
            Common.Click(Locators.StoreDJIFrontPage.searhIcon);
        }

        public static void ClickFirstDJIMini3Product()
        {
            Common.Click(Locators.StoreDJIFrontPage.firstDJIMini3ProductLink); 
        }

        public static string GetProductText()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.itemInShoppingCart);
        }

        public static bool WaitForDJIMini3BeVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.StoreDJIFrontPage.firstDJIMini3ProductLink);
        }

        public static bool WaitForDJIMini3InProductPageBeVisible()
        {
            return Common.WaitForElementToBeVisible(Locators.StoreDJIFrontPage.productText);
        }

        public static void ScrollTillDJIMini3FlyMoreComboOptionIsVisible()
        {
            Common.ScrollUntilElementIsClickable(Locators.StoreDJIFrontPage.dJIMini3FlyMoreComboOption);
        }

        public static void ClickDJIMini3FlyMoreComboOption()
        {
            Common.Click(Locators.StoreDJIFrontPage.dJIMini3FlyMoreComboOption);
        }

        public static void ClickShopNowButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.shopNowButton);
        }

        public static void ClickContinueWithoutCoverageButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.continueWithoutCoverageButton);
        }

        public static void WaitTillWithoutCoverageButtonBeEnabled()
        {
            Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.continueWithoutCoverageButton);
        }

        public static void ClickViewCartAndCheckoutButton()
        {
            Common.Click(Locators.StoreDJIFrontPage.viewCartAndCheckoutButton);
        }

        public static void WaitTillViewCartAndCheckouButtonBeEnabled()
        {
            Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.viewCartAndCheckoutButton);
        }

        public static void WaitTillItemInCartBeViewable()
        {
            Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.itemInShoppingCart);
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
