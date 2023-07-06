using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.FeedPageObject
{
    public class FeedPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _analyticsButton = By.XPath("//a[@href='/lenta/tags/аналитика/?from=strichan']");
        private readonly By _articlesButton = By.XPath("//a[@href='/lenta/articles/?from=strichart']");
        private readonly By _interviewsButton = By.XPath("//a[@href= '/lenta/interviews/?from=strichart']");
        private readonly By _newsButton = By.XPath("//a[@href= '/lenta/news/?from=strichnews']");

        public FeedPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public AnalyticsPageObject AnalyticPage()
        {
            _webDriver.FindElement(_analyticsButton).Click();

            return new AnalyticsPageObject(_webDriver);
        }

        public ArticlesFeedPageObject ArticlesPage()
        {
            _webDriver.FindElement(_articlesButton).Click();

            return new ArticlesFeedPageObject(_webDriver);
        }

        public InterviewsPageObject InterviewsPage()
        {
            _webDriver.FindElement(_interviewsButton).Click();

            return new InterviewsPageObject(_webDriver);
        }

        public NewsPageObject NewsPage()
        {
            _webDriver.FindElement(_newsButton).Click();

            return new NewsPageObject(_webDriver);
        }
    }
}