using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.PageObjectsFromMainPaige
{
    public class Top50CompaniesPageObject
    {
        private IWebDriver _webDriver;

        public Top50CompaniesPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public MainPageObject BackToMain()
        {
            return new MainPageObject(_webDriver);
        }
    }
}