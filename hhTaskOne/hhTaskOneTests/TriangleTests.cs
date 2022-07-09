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
    public class TriangleTests
    {
        Triangle triangle = new Triangle(3, 4, 5); // цифры для True проверки

        [TestMethod()]
        public void getAreaTest()
        {
            Assert.AreEqual(triangle.getArea(), 4.47213595499958);
        }

        [TestMethod()]
        public void isRightTriangleTest()
        {
            Assert.AreEqual(triangle.isRightTriangle(), true);
        }
    }
}