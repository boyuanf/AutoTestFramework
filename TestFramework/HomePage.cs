using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace TestFramework
{
    public class HomePage
    {
        public static string Url { get; set; }
        private static string PageTitle = "Pluralsight";

        private By userType = By.XPath("html/body/div/div/div/div/div[4]/div[3]/div/div[2]/div[3]/a[1]/span");

        static HomePage()
        {
            Url = "http://pluralsight.com";
        }

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public void SelectUserType()
        {
            Browser.Driver.FindElement(userType).Click();
        }

        public bool IsAt()
        {
            return Browser.Title.Contains(PageTitle);
        }
    }
}