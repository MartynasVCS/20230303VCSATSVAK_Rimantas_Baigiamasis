using NUnit.Framework;
using SeleniumFramework.Pages.DJI_store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.DJIStore
{
    internal class TS001_SearchAndAddProductToCartTests : BaseTests
    {
        [Test]
        public void TC001_SearchForDJIMini3()
        {
            string expectedResult = "DJI Mini 3 Fly More Combo (DJI RC-N1)";
            string inputTextInToSearchBar = "DJI Mini 3";

            StoreDJIFrontPage.Open();
            StoreDJIFrontPage.ClickSearchButton();
            StoreDJIFrontPage.EnterProductNameInSearchBox(inputTextInToSearchBar);
            StoreDJIFrontPage.ClickSearchIconInSearchBar();
            StoreDJIFrontPage.WaitForDJIMini3BeVisible();
            StoreDJIFrontPage.ClickFirstDJIMini3Product();
            StoreDJIFrontPage.WaitForAcceptAllButtonBeEnabled();
            StoreDJIFrontPage.ClickAcceptAllButton();
            StoreDJIFrontPage.ScrollTillDJIMini3FlyMoreComboOptionIsVisible();
            StoreDJIFrontPage.ClickDJIMini3FlyMoreComboOption();
            StoreDJIFrontPage.ClickShopNowButton();
            StoreDJIFrontPage.WaitTillWithoutCoverageButtonBeEnabled();
            StoreDJIFrontPage.ClickContinueWithoutCoverageButton();
            StoreDJIFrontPage.WaitTillViewCartAndCheckouButtonBeEnabled();
            StoreDJIFrontPage.ClickViewCartAndCheckoutButton();
            StoreDJIFrontPage.WaitTillItemInCartBeViewable();
            
            string actualResult = StoreDJIFrontPage.GetProductText();
            StringAssert.Contains(expectedResult, actualResult);
        }
    }
}