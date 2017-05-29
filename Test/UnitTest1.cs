using System;
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

        [TestCleanup]
        public void CleanUp()
        {
            Browser.Close();
        }
    }

}
