using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.FeedPageObject
{
    public class NewsPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _selectOption = By.XPath("//select[@name='category']/option[text()='Новини']");
        
        public NewsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public bool IsOnNewsPage()
        {
            string option = _webDriver.FindElement(_selectOption).Text;

            return option.ToLower() == "новини" ? true : false;
        }
    }
}