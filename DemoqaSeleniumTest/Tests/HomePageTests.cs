using BasicSeleniumTest.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSeleniumTest.Tests
{
	public class HomePageTests: BaseTest<HomePage>
	{
		[Test]
		public void WhenCustomerOpensHomepage_ThenHomepageIsOpenedAndPageTitleIsCorrect()
		{
			var result = TestedPage.IsTextBoxIsVisible();
			Assert.IsTrue(result);
		}

		[Test]
		public void WhenCustomerOpensButtonsPageAndClicksOnClickMeButton_MessageIsCorrect()
		{
			var buttonsPage = NavigationBar.GetButtonsPage();
			var givenClickClickMeButtonResult = buttonsPage.ClickClickMeButtonAndGetResult();
			var correctClickClickMeButtonResult = "You have done a dynamic click";

			Assert.AreEqual(givenClickClickMeButtonResult, correctClickClickMeButtonResult);
        }

		protected override HomePage SelectTestedAppPage()
			 => NavigationBar.ClickElementsLink();
	}
}
