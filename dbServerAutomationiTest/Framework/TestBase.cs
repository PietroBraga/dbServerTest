using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dbServerAutomationiTest
{
    [TestClass]
    public class TestBase
    {
        [TestInitialize]

        public void Initialize()
        {
            Browser.Initialize();
        }
        
        [TestCleanup]
        public void TestCleanup()
        {
            Browser.CleanUp();
        }
    }
}
