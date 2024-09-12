using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShindinDN.Sprint0.Task2.V0.Lib;

namespace Tyuiu.ShindinDN.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Денис";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Денис", res);
        }
    }
}