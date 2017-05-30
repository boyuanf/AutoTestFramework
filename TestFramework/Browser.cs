using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;

namespace TestFramework
{
    public static class Browser
    {
        public static IWebDriver Driver {
            get { return webDriver; }
        }

        public static Actions Action
        {
            get { return action; }
        }

        static IWebDriver webDriver = new FirefoxDriver();
        static Actions action = new Actions(webDriver);


        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = url;
        }

        public static void Close()
        {
            webDriver.Close();
        }
    }
}
