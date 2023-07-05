using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.ForumPage
{
    public class ForumPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _technicalArticles = By.XPath("//a[@href='https://dou.ua/forums/tags/tech/?from=fortech']");
        private readonly By _blogs = By.XPath("//a[@href='https://dou.ua/forums/blogs/?from=forcol']");

        public ForumPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public TechnicalArticlesPageObject TechnicalArticles()
        {
            _webDriver.FindElement(_technicalArticles).Click();

            return new TechnicalArticlesPageObject(_webDriver);
        }

        public BlogsPageObject Blogs()
        {
            _webDriver.FindElement(_blogs).Click();

            return new BlogsPageObject(_webDriver);
        }
    }
}