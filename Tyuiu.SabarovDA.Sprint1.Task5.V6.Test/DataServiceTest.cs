using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SabarovDA.Sprint1.Task5.V6.Lib;

namespace Tyuiu.SabarovDA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 100;
            int dayOfWeek = ds.Calculate(k);
            Assert.AreEqual(2, dayOfWeek);



        }
    }
}
