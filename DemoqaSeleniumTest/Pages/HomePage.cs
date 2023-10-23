using BasicSeleniumTest.Models.Consts;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSeleniumTest.Pages
{
	public class HomePage : BasicPage
	{
		public HomePage(IWebDriver driver) : base(driver) { }


		public bool IsTextBoxIsVisible()
		{
			var result = GetTextOfElement(By.XPath("(//span[normalize-space()='Text Box'])[1]"));

			if (result == "Text Box")
				return true;
			return false;
		}

		public override void GoTo()
		{
			Driver.Navigate().GoToUrl(PageLink.HomePage);
		}
	}
}
