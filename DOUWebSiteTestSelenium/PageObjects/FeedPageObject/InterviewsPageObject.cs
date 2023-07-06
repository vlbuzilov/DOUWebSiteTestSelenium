using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.FeedPageObject
{
    public class InterviewsPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _selectOption = By.XPath("//select[@name='category']/option[text()='Інтерв’ю']");
        
        public InterviewsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
        
        public bool IsOnInterviewsPage()
        {
            string option = _webDriver.FindElement(_selectOption).Text;

            return option.ToLower() == "інтерв’ю" ? true : false;
        }
    }
}