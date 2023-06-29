using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.PageObjectsFromMainPaige
{
    public class FirstWorkPageObject
    {
        private IWebDriver _webDriver;

        public FirstWorkPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject BackToMain()
        {
            return new MainPageObject(_webDriver);
        }
    }
}