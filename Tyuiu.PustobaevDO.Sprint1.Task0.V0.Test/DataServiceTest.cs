﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PustobaevDO.Sprint1.Task0.V11.Lib;

namespace Tyuiu.PustobaevDO.Sprint1.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}
