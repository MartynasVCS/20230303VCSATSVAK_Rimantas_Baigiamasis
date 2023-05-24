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
            string correctEmail = "gintilas.rimants@gmail.com";
            
            AccountDJILoginPage.Open();
            AccountDJILoginPage.WaitForAcceptAllButtonBeEnabled();
            AccountDJILoginPage.ClickAcceptAllButton();
            AccountDJILoginPage.EnterEmail(correctEmail);
            AccountDJILoginPage.ClickLogIn();
            AccountDJILoginPage.WaitForPasswordCannotBeEmptyBeVisible();
            string actualResult = AccountDJILoginPage.GetPasswordCannotBeEmpyText();

            StringAssert.Contains(expectedResult, actualResult);
        }
        [Test]
        public void TC004_LoginWithInvalidPassword()
        {
            string expectedResult = "Your email or password is incorrect";
            string correctEmail = "gintilas.rimants@gmail.com";
            string incorrectPassword = "1234";

            AccountDJILoginPage.Open();
            AccountDJILoginPage.WaitForAcceptAllButtonBeEnabled();
            AccountDJILoginPage.ClickAcceptAllButton();
            AccountDJILoginPage.EnterEmail(correctEmail);
            AccountDJILoginPage.EnterPassword(incorrectPassword); //ReCaptcha isijungia
            AccountDJILoginPage.ClickLogIn();
            //AccountDJILoginPage.WaitYourEmailIsIncorrectTextBeVisible();
            string actualResult = AccountDJILoginPage.GetYourEmailIsIncorrectText();

            StringAssert.Contains(expectedResult, actualResult);
        }

    }
}