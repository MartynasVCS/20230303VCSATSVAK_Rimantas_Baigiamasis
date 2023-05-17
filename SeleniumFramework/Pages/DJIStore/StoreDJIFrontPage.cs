using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFramework.Pages.DJI_store
{
    public class StoreDJIFrontPage
    {
        public static void Open()
        {
            Driver.OpenPage("https://https://store.dji.com/lt");
        }
        public static void EnterMessage(string message)
        {
            string locator = "";
            Common.SendKeys(locator, message);
        }

        //public static void SelectColorInOldStyleMenu(string expectedColor)
        //{
        //    Common.SelectOptionByText(Locators.SelectMenu.selectOldStyleMenu, expectedColor);
        //}

        //public static string GetSelectedColorInOldStyleMenu()
        //{
        //    return Common.GetSelectedOption(Locators.SelectMenu.selectOldStyleMenu);
        //}

        //public static void SelectTitleInSelectOneMenu(string expectedTitle)
        //{
        //    Common.Click(Locators.SelectMenu.selectSelectOneMenu);
        //    Common.Click($"//*[contains(@id, 'react-select') and contains(text(),'{expectedTitle}')]");
        //}

        //public static string GetSelectedTitleInSelectOneMenu()
        //{
        //    return Common.GetElementText(Locators.SelectMenu.selectSelectOneMenu);
        //}
    }
}
