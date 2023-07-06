using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DOUWebSiteTestSelenium.PageObjects
{
    [TestFixture]
    public class FeedPageTests
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

        [Test] public void AnalyticsTest()
        {
            var mainPage = new MainPageObject(_webDriver);

            bool result = mainPage.RedirectToFeedPageObject().AnalyticPage().IsOnAnalyticsPage();
            Assert.AreEqual(result, true);
        }

        [Test] public void ArticlesTest()
        {
            var mainPage = new MainPageObject(_webDriver);

            bool result = mainPage.RedirectToFeedPageObject().ArticlesPage().IsOnArticlesPage();
            Assert.AreEqual(result, true);
        }
        
        [Test] public void InterviewsPageTest()
        {
            var mainPage = new MainPageObject(_webDriver);

            bool result = mainPage.RedirectToFeedPageObject().InterviewsPage().IsOnInterviewsPage();
            Assert.AreEqual(result, true);
        }
        
        [Test] public void NewsPageTest()
        {
            var mainPage = new MainPageObject(_webDriver);

            bool result = mainPage.RedirectToFeedPageObject().NewsPage().IsOnNewsPage();
            Assert.AreEqual(result, true);
        }
        
        
        [OneTimeTearDown] public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}