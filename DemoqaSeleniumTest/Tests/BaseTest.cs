using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSeleniumTest.Helpers;
using BasicSeleniumTest.Pages;

namespace BasicSeleniumTest.Tests
{
    public abstract class BaseTest<T>
	{
		private IWebDriver _driver;

		[SetUp]
		public void Setup()
		{
			ChromeOptions options = new ChromeOptions();
			//options.AddArgument("--headless");

			_driver = new ChromeDriver(options);
			_homePage = new HomePage(_driver);
			_homePage.GoTo();
			NavigationBar = new NavigationBar(_driver);
			TestedPage = SelectTestedAppPage();
			
		}

		[TearDown]
		public void Teardown()
		{
			_driver.Quit();
		}
		protected abstract T SelectTestedAppPage();
		protected T TestedPage { get; set; }
		protected NavigationBar NavigationBar { get; set; }
		private HomePage _homePage;
		
	}
}
