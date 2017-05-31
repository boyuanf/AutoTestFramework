using System;
using System.Drawing.Printing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanGoToHomePage()
        {
            Page.HomePage.Goto();
            Assert.IsTrue(Page.HomePage.IsAt());
        }

        [TestMethod]
        public void CanGoToAuthorPage()
        {
            Page.HomePage.Goto();
            Page.HomePage.SelectUserType();
            Page.Authors.Goto();
            Page.Authors.FindAuthor("Matt Milner");
            Assert.IsTrue(Page.Authors.IsAtAuthorPage("Matt Milner"));

        }

        [TestCleanup]
        public void CleanUp()
        {
            //Browser.Close();
        }
    }

}
