using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.FeedPageObject
{
    public class AnalyticsPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _anayticsText = By.XPath("//h1[contains(text(), 'аналітика')]");

        public AnalyticsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public bool IsOnAnalyticsPage()
        {
            string text = _webDriver.FindElement(_anayticsText).Text;
            if (text.Contains("аналітика")) return true;
            return false;
        }
    }
}