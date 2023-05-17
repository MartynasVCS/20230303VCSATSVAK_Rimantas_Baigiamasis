using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFramework;
using SeleniumFramework.Pages.DJI_store;

namespace SeleniumTests.DJIStore

{
    internal class TS004_ChangeRegionTest : BaseTests
    {
        [Test]
        public void TC005_ChangeTheRegionLanguageCurrency()
        {
            string expectedResult = "Latvia English € EUR";
            
            Driver.InitializeDriver();
            StoreDJIFrontPage.Open();

            StoreDJIFrontPage.WaitForRegionSelectionButtonBeEnabled();

            StoreDJIFrontPage.ClickYourCountryRegionSelectionButton();

            StoreDJIFrontPage.ScrollUntilElementIsClickableInPopUp(); 
            StoreDJIFrontPage.ClickSelectYourRegionLatviaSelectionButton(); //Uzstrigau cia nes POP UP lange nesimato elemento. 
            string actualResult = StoreDJIFrontPage.SelectedCountryRegionLatvia();

            StringAssert.Contains(expectedResult, actualResult);

            Driver.ShutdownDriver();
        }

    }
}