using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSeleniumTest.Pages
{
	public class NavigationBar : BasicPage
	{
		public NavigationBar(IWebDriver driver) : base(driver) { }

		public HomePage ClickElementsLink()
		{

            OpenChildOfParent();

			return new HomePage(Driver);
		}

        public ButtonsPage GetButtonsPage()
        {
            OpenChildOfParent();

			Click(By.XPath("//span[normalize-space()='Buttons']"));
			return new ButtonsPage(Driver);
        }

		public void OpenChildOfParent()
		{
            var listOfChilds = By.XPath("(//div[contains(@class,'element-list collapse show')])[1]");
            var isExists = IsElementExists(listOfChilds);

            if (isExists)
            {
                var button = GetChildOfParent(listOfChilds, By.CssSelector(".group-header"));
                button.Click();
            }

            Click(By.XPath("(//div[contains(@class,'element-group')])[1]"));
        }
    }
}
