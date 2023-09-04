using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GrigorevKU.Sprint0.Task2.V0.Lib;

namespace Tyuiu.GrigorevKU.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Костя";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Костя", res);
        }
    }
}
