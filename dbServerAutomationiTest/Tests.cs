using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace dbServerAutomationiTest
{
    [TestClass]
    public class Tests : TestBase
    {
        [TestMethod]
        public void FirstTest()
        {
            //Search for "Batman" and add to cart
            Pages.MainPage.GoTo();
            Pages.MainPage.Search("Batman");
            Pages.MainPage.SelectItem("Batman");
            Pages.MainPage.AddToCart();

            //Search for "PS3" and add to cart
            Pages.MainPage.GoTo();
            Pages.MainPage.Search("PS3");
            Pages.MainPage.SelectItem("PS3");
            Pages.MainPage.AddToCart();


            Pages.Cart.GoTo();
            Pages.Cart.CheckItems();

            Assert.IsTrue(Pages.Cart.CheckItems(), "Not possible to assert.");
        }
    }
}
