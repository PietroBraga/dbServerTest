using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace dbServerAutomationiTest
{
    public static class Browser
    {
        // Set properties of Browser Class
        public static IWebDriver _webDriver = new ChromeDriver();
        public static string _baseURl = "http://demo.cs-cart.com";

        public static IWebDriver Driver { get { return _webDriver; } }

        public static string UserSession { get; set; }

        //Go to the base url
        internal static void Initialize()
        {
            _webDriver.Navigate().GoToUrl(_baseURl);
            UserSession = _webDriver.Url.ToString();
        }

        //Closes the Browser and the webdriver instance
        public static void CleanUp()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }

        internal static void GoTo(string relativeUrl)
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _webDriver.Navigate().GoToUrl(string.Format("{0}{1}", UserSession, relativeUrl));
        }        
    }
}