using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace TestFramework
{
    public static class Page
    {
        public static class HomePage
        {
            public static string Url { get; set; }
            private static string PageTitle = "Pluralsight";

            static HomePage()
            {
                Url = "http://pluralsight.com";
            }

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
                return Browser.Title.Contains(PageTitle);
            }
        }
    }


}
