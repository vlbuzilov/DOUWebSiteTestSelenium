using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.ForumPage
{
    public class TechnicalArticlesPageObject
    {
        private IWebDriver _webDriver;

        private readonly By _technicalArticles = By.XPath("//h1[text()='Технічні статті й дайджести']");

        public TechnicalArticlesPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public bool isCorrectPage()
        {
            string technicalArticlesTesText = _webDriver.FindElement(_technicalArticles).Text;
            if (technicalArticlesTesText == "Технічні статті й дайджести") return true;
            
            return false;
        }

        public ForumPageObject BackToForumPage()
        {
            return new ForumPageObject(_webDriver);
        }
    }
}