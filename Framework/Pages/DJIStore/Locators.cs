using OpenQA.Selenium.DevTools.V111.DOM;

namespace SeleniumFramework.Pages.DJIStore
{
    internal static class Locators
    {
        internal static class StoreDJIFrontPage
        {
            internal static string countryRegionSelectionButton = "//*[@id='nav']/div[1]/div[1]/div/div[2]/div/div";
            internal static string regionLatviaSelectionButton = "/html/body/div[3]/div/div[2]/div[2]/div/div/div[2]/div[2]/div[15]/div/a";
            internal static string cookyAcceptAllButton = "//div[@class='cc-footer']/button[3]";
            internal static string searchButton = "//*[@data-test-locator='serachClickButton']";
            internal static string searchBar = "//*[@placeholder='Search Products...']";
            internal static string searhIcon = "//*[@aria-label='Submit Search']";
            internal static string firstDJIMini3ProductLink = "//*[@id='store-main-content']/div[2]/div/div/div/section/div[3]/ul/li[1]/a"; //"//*[@id='root']/div/ul/li[1]/a";
            internal static string productText = "/html/body/main/div/section/div/div/section[1]/header/h3"; //"//*[@id='anchorVersion']/h3";
            internal static string dJIMini3FlyMoreComboOption = "/html/body/main/section/main/div[2]/div/div[2]/article/article/section[1]/div/article/div[2]/div/section[3]/div/section/ul/li[2]/label/div/div/div/div/div[1]/header/div";//"//*[@id='anchorSelectoption']/div/div/div/label[2]/div/div";
            internal static string shopNowButton = "//*[@id='gtm_ShopNow']";
            internal static string continueWithoutCoverageButton = "//button[contains(span, 'Continue Without Coverage')]";
            internal static string viewCartAndCheckoutButton = "//button[contains(span,'View Cart & Checkout')]";
            internal static string itemInShoppingCart = "//*[@id='app']/div/article/div/section[3]/div/div[2]/div[1]/div[2]/div[2]/div/div[1]/div/a";
            
            internal static string officialRefurbished = "//li[contains(@class, 'index-module__dji-nav-item') and contains(@href, '/pages/refurbished')]";//"//*[@id='nav']/div[1]/div[2]/nav/div/div[1]/ul/li[6]";
            internal static string handheldProductCategory = "//*[@id='section-refurbished-tab']/div/div[2]/div/div/ul/li[2]/button";
            internal static string handheldProductsAreaText = "//h2[text()='Handheld']";
        }

    }
}