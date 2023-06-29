using System;
using DOUWebSiteTestSelenium.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DOUWebSiteTestSelenium
{
    [TestFixture]
    public class MainPageTests
    {
        private IWebDriver _webDriver;

        [OneTimeSetUp] public void OneTimeSetUtp()
        {
            _webDriver = new ChromeDriver();
        }

        [SetUp] public void SetUp()
        {
            _webDriver.Manage().Cookies.DeleteAllCookies();
            _webDriver.Navigate().GoToUrl(Settings.URLAddress);
            _webDriver.Manage().Window.Maximize();
        }

        [Test] public void MainPageTabTest()
        {
            var mainPageTab = new MainPageObject(_webDriver);
            mainPageTab.FirstWork().BackToMain();
        }

        [TearDown] public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}