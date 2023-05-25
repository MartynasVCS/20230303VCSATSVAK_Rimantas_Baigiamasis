using NUnit.Framework;
using SeleniumFramework.Pages.DJI_store;

namespace SeleniumTests.DJIStore
{
    internal class TS004_ChangeRegionTest : BaseTests
    {
        [Test]
        public void TC005_ChangeTheRegionLanguageCurrency()
        {
            string expectedResult = "Latvia (English / € EUR)";
            
            StoreDJIFrontPage.Open();
            System.Threading.Thread.Sleep(2000);
            StoreDJIFrontPage.WaitForAcceptAllButtonBeEnabled();
            StoreDJIFrontPage.ClickAcceptAllButton();
            StoreDJIFrontPage.WaitForRegionSelectionButtonBeEnabled();
            StoreDJIFrontPage.ClickYourCountryRegionSelectionButton();
            StoreDJIFrontPage.ClickSelectYourRegionLatviaSelectionButton();
            System.Threading.Thread.Sleep(1000);
            string actualResult = StoreDJIFrontPage.SelectedCountryRegionLatvia();

            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}