using SeleniumFramework;
using SeleniumFramework.Pages;
using SeleniumFramework.Pages.DJIStore;
using System.Threading.Tasks;

namespace Framework.Pages.DJIStore
{
    public class AccountDJILoginPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://account.dji.com/login");
        }
        public static void EnterEmail(string email)
        {
            Common.SendKeys(Locators.StoreDJIFrontPage.emailInputField, email);
        }

        public static void ClickLogIn()
        {
           Common.Click(Locators.StoreDJIFrontPage.logInButton);
        }

        public static string GetPasswordCannotBeEmpyText()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.passwordCanNotBeEmptyMessage);
        }

        public static void EnterPassword(string keys)
        {
            Common.SendKeys(Locators.StoreDJIFrontPage.passwordInputField, keys);
        }

        public static string GetFollowTheProptsToCompleteText()
        {
            return Common.GetElementText(Locators.StoreDJIFrontPage.followThePromptsToCompleteMessage);
        }

        public static bool WaitForPasswordCannotBeEmptyBeVisible()
        {
            return Common.WaitForElementToBeEnabled(Locators.StoreDJIFrontPage.passwordCanNotBeEmptyMessage);
        }

        public static void Wait()
        {
            Task.Run(async () => await Common.Wait()).Wait(); 
        }
    }
}
