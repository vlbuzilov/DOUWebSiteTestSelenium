using DOUWebSiteTestSelenium.PageObjects;
using DOUWebSiteTestSelenium.PageObjects.ForumPage;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DOUWebSiteTestSelenium
{
    [TestFixture]
    public class ForumPageTests
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
        
        //tests
        //======================================================================================================================================
        [Test] public void TechnicalArticlesTest()
        {
            var mainPage = new MainPageObject(_webDriver);
        
            bool result = mainPage.RedirectToForumPageObject().TechnicalArticles().isCorrectPage();
            
        
            Assert.AreEqual(result, true);
        }

        [Test] public void BlogsPageTest()
        {
            var mainPage = new MainPageObject(_webDriver);

            bool result = mainPage.RedirectToForumPageObject().Blogs().IsOnPage();
            
            
            Assert.AreEqual(result, true);
        }
        
        
        [OneTimeTearDown] public void TearDown()
        {
            _webDriver.Quit();
        }
    }
}