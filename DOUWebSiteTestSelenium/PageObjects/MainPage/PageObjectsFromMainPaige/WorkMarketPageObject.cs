using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.PageObjectsFromMainPaige
{
    public class WorkMarketPageObject
    {
        private IWebDriver _webDriver;

        public WorkMarketPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject BackToMain()
        {
            return new MainPageObject(_webDriver);
        }
    }
}