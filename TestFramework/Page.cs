using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace TestFramework
{
    public static class Page
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                return homePage;
            }
        }

        public static Authors Authors
        {
            get
            {
                var authors = new Authors();
                return authors;
            }
        }
    }

    public class HomePage
    {
        public static string Url { get; set; }
        private static string PageTitle = "Pluralsight";

        static HomePage()
        {
            Url = "http://pluralsight.com";
        }

        public void Goto()
        {
            Browser.Goto(Url);
            Browser.Driver.FindElement(By.XPath("html/body/div/div/div/div/div[4]/div[3]/div/div[2]/div[3]/a[1]/span")).Click();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains(PageTitle);
        }
    }

    public class Authors
    {
        public void Goto()
        {
            Browser.Action.MoveToElement(Browser.Driver.FindElement((By.XPath("html/body/div/div/noindex/div/header/div[1]/div[2]/ul/li[3]/a")))).Build().Perform();
            //Browser.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            WebDriverWait waitAuthors = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(5));
            var authors = waitAuthors.Until(x => x.FindElement(By.XPath("html/body/div[1]/div/noindex/div/header/div[1]/div[2]/ul/li[3]/div/div/div[2]/div/div[1]/a")));
            Actions hoverAction = Browser.Action.MoveToElement(authors).Click();
            hoverAction.Build().Perform();
        }

        public void FindAuthor(string authorName)
        {
            WebDriverWait waitAuthors = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(5));
            var authorNameInput = waitAuthors.Until(x => x.FindElement(By.Name("author-list-text-search-text")));
            authorNameInput.SendKeys(authorName);
            WebDriverWait waitAuthor = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(5));
            var authorLink = waitAuthor.Until(x => x.FindElement(By.XPath("html/body/div[1]/div/div/div/div[2]/div/div/div/div[3]/div/div/a/div[2]")));
            authorLink.Click();
        }
    }

}
