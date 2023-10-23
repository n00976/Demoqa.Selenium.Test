using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSeleniumTest.Pages
{
    public class ButtonsPage : BasicPage
    {
        public ButtonsPage(IWebDriver driver) : base(driver)
        {
        }

        public string ClickClickMeButtonAndGetResult()
        {
            try
            {
                Click(By.XPath("//button[.='Click Me']"));
            }
            catch
            {
                Console.WriteLine( "error");
            }           
            var ClickMeButtonResult = GetTextOfElement(By.CssSelector("#dynamicClickMessage"));
            return ClickMeButtonResult;
        }


    }
}
