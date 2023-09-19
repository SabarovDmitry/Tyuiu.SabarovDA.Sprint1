using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SabarovDA.Sprint1.Task1.V7.Lib;

namespace Tyuiu.SabarovDA.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);

        }
    }
}
