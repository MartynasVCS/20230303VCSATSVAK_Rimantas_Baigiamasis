using NUnit.Framework;
using SeleniumFramework.Pages.DJI_store;

namespace SeleniumTests.DJIStore
{
    internal class TS003_NavigateToTheRefurbishedProductsCategoryTest : BaseTests
    {
        [Test]
        public void TC004_NavigateToTheRefurbishedProductsCategory()
        {
            string expectedResult = "Handheld";
            
            StoreDJIFrontPage.Open();
            System.Threading.Thread.Sleep(2000);
            StoreDJIFrontPage.ClickOfficialRefurbished();
            StoreDJIFrontPage.WaitForAcceptAllButtonBeEnabled();
            StoreDJIFrontPage.ClickAcceptAllButton();
            StoreDJIFrontPage.ClickHandheldProductCategory();
            string actualResult = StoreDJIFrontPage.GetHandheldProductsAreaText();

            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}