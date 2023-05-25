using SeleniumFramework.Pages.DJIStore;

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

        public static void ClickOfficialRefurbished()
        {
            Common.Click(Locators.StoreDJIFrontPage.officialRefurbished);
        }

        public static void ClickHandheldProductCategory()
        {
            Common.Click(Locators.StoreDJIFrontPage.handheldProductCategory);
        }

        public static string GetHandheldProductsAreaText()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.handheldProductsAreaText);
        }
    }
}
