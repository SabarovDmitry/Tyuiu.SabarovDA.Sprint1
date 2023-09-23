using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SabarovDA.Sprint1.Task3.V18.Lib;

namespace Tyuiu.SabarovDA.Sprint1.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 10;
            double b = 20;
            double c = 5;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(8, res);

        }
    }
}
