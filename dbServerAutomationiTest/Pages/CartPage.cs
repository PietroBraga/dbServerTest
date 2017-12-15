using OpenQA.Selenium;
using System;

namespace dbServerAutomationiTest
{
    public class CartPage
    {
        internal void GoTo()
        {
            Browser.GoTo("cart/");
        }

        internal bool CheckItems()
        {
            var batmanItemIsAt = Browser.Driver.FindElement(By.XPath(".//a[contains(text(), 'Batman')]")).Enabled;
            var ps3ItemIsAt = Browser.Driver.FindElement(By.XPath(".//a[contains(text(), 'PS3')]")).Enabled;

            if (batmanItemIsAt == true && ps3ItemIsAt == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}