using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SabarovDA.Sprint1.Task6.V16.Lib;

namespace Tyuiu.SabarovDA.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "У тебя есть ластик ? Только не ври что у тебя его нет !";
            DataService ds = new DataService();
            bool res =  ds.CheckSpecSymbols(strTest);
            Assert.IsTrue(res);




        }
    }
}
