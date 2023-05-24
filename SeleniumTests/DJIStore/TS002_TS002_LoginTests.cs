using Framework.Pages.DJIStore;
using NUnit.Framework;
using SeleniumFramework.Pages.DJI_store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.DJIStore
{
    internal class TS002_LoginTests : BaseTests
    {
        [Test]
        public void TC003_LoginWithoutPassword()
        {
            string expectedResult = "Password cannot be empty";
            string correctEmail = "gintilas.rimantas@gmail.com";

            AccountDJILoginPage.Open();
            AccountDJILoginPage.Wait();
            //AccountDJILoginPage.WaitForAcceptAllButtonBeEnabled();
            //AccountDJILoginPage.ClickAcceptAllButton();
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.EnterEmail(correctEmail);
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.ClickLogIn();
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.WaitForPasswordCannotBeEmptyBeVisible();
            AccountDJILoginPage.Wait();
            string actualResult = AccountDJILoginPage.GetPasswordCannotBeEmpyText();

            StringAssert.Contains(expectedResult, actualResult);
        }
        [Test]
        public void TC004_LoginWithInvalidPassword()
        {
            string expectedResult2 = "Please follow the prompts to complete the verify";
            string correctEmail = "gintilas.rimantas@gmail.com";
            string incorrectPassword = "1234";

            AccountDJILoginPage.Open();
            AccountDJILoginPage.Wait();
            //AccountDJILoginPage.WaitForAcceptAllButtonBeEnabled();
            //AccountDJILoginPage.ClickAcceptAllButton();
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.EnterEmail(correctEmail);
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.EnterPassword(incorrectPassword); 
            //AccountDJILoginPage.WaitTillRecapchaBeActive();
            //AccountDJILoginPage.ClickRecapcha();//neranda recaptCha elemento
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.ClickLogIn();
            //AccountDJILoginPage.WaitYourEmailIsIncorrectTextBeVisible();
            string actualResult = AccountDJILoginPage.GetFollowTheProptsToCompleteText();

            StringAssert.Contains(expectedResult2, actualResult);
        }

    }
}