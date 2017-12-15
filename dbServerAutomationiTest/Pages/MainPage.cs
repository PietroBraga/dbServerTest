using OpenQA.Selenium;
using System;
using System.Threading;

namespace dbServerAutomationiTest
{
    public class MainPage
    {
        public void GoTo()
        {
            Browser.GoTo("");
        }

        internal void Search(string productName)
        {
            // Find the search bar and submit a search
            var searchElement = Browser.Driver.FindElement(By.Id("search_input"));
            var searchButton = Browser.Driver.FindElement(By.XPath(".//*[@id='tygh_main_container']/div[2]/div/div[1]/div[3]/div/div[1]/div/div/form/button"));
            searchElement.SendKeys(productName);
            searchButton.Submit();
        }

        internal void AddToCart()
        {
            var addToCartButton = Browser.Driver.FindElement(By.XPath(".//button[contains(text(), 'Add to cart')]"));
            addToCartButton.Submit();

            var continueShoppingButton = Browser.Driver.FindElement(By.XPath(".//a[contains(text(), 'Continue shopping')]"));
            continueShoppingButton.Click();

            //Thread.Sleep(2000);


        }

        internal void SelectItem(string productName)
        {
            var productItem = Browser.Driver.FindElements(By.PartialLinkText(productName));
            productItem[productItem.Count - 1].Click();
        }
    }
}