using Microsoft.VisualStudio.TestTools.UnitTesting;
using hhTaskOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hhTaskOne.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void getAreaTest()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(circle.getArea(), Math.PI * 10);
        }
    }
}