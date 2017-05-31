using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


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

        public static AuthorPage AuthorPage
        {
            get
            {
                var authorPage = new AuthorPage();
                return authorPage;
            }
        }
    }
}
