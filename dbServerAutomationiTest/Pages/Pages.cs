using OpenQA.Selenium.Support.PageObjects;

namespace dbServerAutomationiTest
{
    public static class Pages
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.Driver, page);
            return page;
        }
        public static MainPage MainPage
        {
            get
            {
                return GetPage<MainPage>();
            }

        }

        public static CartPage Cart
        {
            get
            {
                return GetPage<CartPage>();
            }
        }
    }
}