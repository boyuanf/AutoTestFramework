using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFramework
{
    public class AuthorPage
    {
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div[1]/div/div[2]/h2")]
        private IWebElement authorName;

        public string AuthorName {
            get { return authorName.Text; }
        }
    }
}