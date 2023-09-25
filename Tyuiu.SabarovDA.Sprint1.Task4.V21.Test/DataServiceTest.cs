using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SabarovDA.Sprint1.Task4.V21.Lib;

namespace Tyuiu.SabarovDA.Sprint1.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double wait = 7.733;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
