using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DOUWebSiteTestSelenium.PageObjects.ForumPage
{
    public class BlogsPageObject
    {
        private IWebDriver _webDriver;
        private ReadOnlyCollection<IWebElement> menuItems;

        private readonly By _menuBar = By.ClassName("b-content-menu");

        public BlogsPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            menuItems = null;
        }

        private void ConvertMenuToList()
        {
            IWebElement menu = _webDriver.FindElement(_menuBar);
            menuItems = menu.FindElements(By.TagName("li"));
        }

        public bool IsOnPage()
        {
            ConvertMenuToList();
            if (menuItems != null) return true;
            return false;
        }
        
        
        public ForumPageObject BackToForumPage()
        {
            return new ForumPageObject(_webDriver);
        }
    }
}