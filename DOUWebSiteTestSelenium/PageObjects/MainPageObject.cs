using DOUWebSiteTestSelenium.PageObjects.PageObjectsFromMainPaige;
using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _firstWorkButton = By.XPath("//a[contains(text(), 'Перша робота')]");

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public FirstWorkPageObject FirstWork()
        {
            _webDriver.FindElement(_firstWorkButton).Click();
            
            return new FirstWorkPageObject(_webDriver);
        }
    }
}