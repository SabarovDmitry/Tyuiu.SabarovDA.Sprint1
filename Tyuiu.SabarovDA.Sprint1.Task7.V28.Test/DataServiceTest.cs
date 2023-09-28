using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SabarovDA.Sprint1.Task7.V28.Lib;

namespace Tyuiu.SabarovDA.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            double wait = 2.444;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);


        }
    }
}
