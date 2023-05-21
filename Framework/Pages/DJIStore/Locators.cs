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
        }

    }
}