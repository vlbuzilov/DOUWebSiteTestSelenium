using DOUWebSiteTestSelenium.PageObjects.ForumPage;
using DOUWebSiteTestSelenium.PageObjects.PageObjectsFromMainPaige;
using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects
{
    public class MainPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _authorizationButton = By.XPath("//a[@id = 'login-link']");

        private readonly By _firstWorkButton = By.XPath("//a[contains(text(), 'Перша робота')]");
        private readonly By _ITCareerebutton = By.XPath("//a[@style='color:#ae0000' and text()='Кар’єра в IT']");
        private readonly By _workMarketButton = By.XPath("//a[@style='color:#00ae00' and text()='Ринок праці']");
        private readonly By _top50CompaniesButton = By.XPath("//a[@style='color:#6699FF;' and text()='Топ-50']");

        //paths for rediecting
        private readonly By _forumButton = By.XPath("//a[@href='https://dou.ua/forums/' and text()='Форум']");

        public MainPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public FirstWorkPageObject FirstWork()
        {
            _webDriver.FindElement(_firstWorkButton).Click();
            
            return new FirstWorkPageObject(_webDriver);
        }

        public ITCareerPageObject ITCareer()
        {
            _webDriver.FindElement(_ITCareerebutton).Click();

            return new ITCareerPageObject(_webDriver);
        }

        public WorkMarketPageObject WorkMarket()
        {
            _webDriver.FindElement(_workMarketButton).Click();

            return new WorkMarketPageObject(_webDriver);
        }

        public Top50CompaniesPageObject Top50Companies()
        {
            _webDriver.FindElement(_top50CompaniesButton).Click();

            return new Top50CompaniesPageObject(_webDriver);
        }
        
        //redirecting
        public ForumPageObject RedirectToForumPageObject()
        {
            _webDriver.FindElement(_forumButton).Click();

            return new ForumPageObject(_webDriver);
        }
    }
}