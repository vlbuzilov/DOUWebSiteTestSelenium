using System;
using System.Threading;
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

        //Tab tests
        //==================================================================================================================
        [Test] public void MainPageFirstWorkTest()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage.FirstWork().BackToMain();
        }

        [Test] public void MainPageITCareerTest()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage.ITCareer().BackToMain();
        }

        [Test] public void MainPageWorkMarket()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage.WorkMarket().BackToMain();
        }

        [Test] public void MainPageTop50Companies()
        {
            var mainPage = new MainPageObject(_webDriver);
            mainPage.Top50Companies().BackToMain();
        }

        [OneTimeTearDown] public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}