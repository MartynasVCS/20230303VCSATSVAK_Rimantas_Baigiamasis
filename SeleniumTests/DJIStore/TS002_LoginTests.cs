using Framework.Pages.DJIStore;
using NUnit.Framework;

namespace SeleniumTests.DJIStore
{
    internal class TS002_LoginTests : BaseTestsWithChromeProfile
    {
        [Test]
        public void TC002_LoginWithoutPassword()
        {
            string expectedResult = "Password cannot be empty";
            string correctEmail = "abc@gmail.com";

            AccountDJILoginPage.Open();
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
        public void TC003_LoginWithoutReCaptchaVerification()
        {
            string expectedResult2 = "Please follow the prompts to complete the verify";
            string correctEmail = "abc@gmail.com";
            string incorrectPassword = "1234";

            AccountDJILoginPage.Open();
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.EnterEmail(correctEmail);
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.EnterPassword(incorrectPassword); 
            AccountDJILoginPage.Wait();
            AccountDJILoginPage.ClickLogIn();
            string actualResult = AccountDJILoginPage.GetFollowTheProptsToCompleteText();

            StringAssert.Contains(expectedResult2, actualResult);
        }

    }
}