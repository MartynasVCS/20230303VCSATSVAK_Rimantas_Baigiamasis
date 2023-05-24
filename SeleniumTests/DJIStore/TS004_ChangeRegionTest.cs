using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework;
using SeleniumFramework.Pages.DJI_store;
using Framework.Pages.DJIStore;

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
            //StoreDJIFrontPage.WaitForAcceptAllButtonBeEnabled();
            //StoreDJIFrontPage.ClickAcceptAllButton();
            StoreDJIFrontPage.WaitForRegionSelectionButtonBeEnabled();
            StoreDJIFrontPage.ClickYourCountryRegionSelectionButton();
            StoreDJIFrontPage.ClickSelectYourRegionLatviaSelectionButton(); 
            string actualResult = StoreDJIFrontPage.SelectedCountryRegionLatvia();

            StringAssert.Contains(expectedResult, actualResult);
        }

    }
}