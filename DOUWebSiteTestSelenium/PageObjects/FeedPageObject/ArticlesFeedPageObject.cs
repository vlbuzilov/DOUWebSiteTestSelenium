using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.FeedPageObject
{
    public class ArticlesFeedPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _selectOption = By.XPath("//select[@name='category']/option[text()='Статті']");

        public ArticlesFeedPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public bool IsOnArticlesPage()
        {
            string option = _webDriver.FindElement(_selectOption).Text;

            return option.ToLower() == "статті" ? true : false;
        }
    }
}