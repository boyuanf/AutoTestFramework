using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestFramework
{
    public class Authors
    {
        private By featureButton = By.XPath("html/body/div/div/noindex/div/header/div[1]/div[2]/ul/li[3]/a");
        private By authorsButton = By.XPath("html/body/div[1]/div/noindex/div/header/div[1]/div[2]/ul/li[3]/div/div/div[2]/div/div[1]/a");
        private By authorsNameSearchBar = By.XPath("html/body/div[1]/div/div/div/div[2]/div/div/div/div[2]/div[3]/form/input[1]");
        private By authorSearchResult = By.XPath("html/body/div[1]/div/div/div/div[2]/div/div/div/div[3]/div/div/a/div[2]");
        private By searchButton = By.XPath("html/body/div[1]/div/div/div/div[2]/div/div/div/div[2]/div[3]/form/button");



        public void Goto()
        {
            Browser.Action.MoveToElement(Browser.Driver.FindElement(featureButton)).Build().Perform();
            //Browser.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            WebDriverWait waitAuthors = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(5));
            var authors = waitAuthors.Until(x => x.FindElement(authorsButton));
            Actions hoverAction = Browser.Action.MoveToElement(authors).Click();
            hoverAction.Build().Perform();
        }

        public void FindAuthor(string authorName)
        {
            WebDriverWait waitAuthors = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(5));
            var authorNameInput = waitAuthors.Until(x => x.FindElement(authorsNameSearchBar));
            authorNameInput.SendKeys(authorName);
            //Browser.Driver.FindElement(searchButton).Click();
            WebDriverWait waitAuthor = new WebDriverWait(Browser.Driver, TimeSpan.FromSeconds(5));
            var authorLink = waitAuthor.Until(x => x.FindElement(authorSearchResult));
            authorLink.Click();
        }

        public bool IsAtAuthorPage(string authorName)
        {
            Browser.Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);
            return authorName == authorPage.AuthorName;
        }
    }
}