using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.PageObjectsFromMainPaige
{
    public class ITCareerPageObject
    {
        private IWebDriver _webDriver;

        public ITCareerPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject BackToMain()
        {
            return new MainPageObject(_webDriver);
        }
    }
}