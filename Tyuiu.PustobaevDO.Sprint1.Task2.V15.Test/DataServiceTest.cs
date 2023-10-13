using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PustobaevDO.Sprint1.Task3.V15.Lib;

namespace Tyuiu.PustobaevDO.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double v1 = 41;
            double v2 = 38;
            double S = 10;
            double T = 44;
            var res = ds.DistanceOverTime(v1, v2, S, T);
            Assert.AreEqual(3466, res);


        }
    }
}
