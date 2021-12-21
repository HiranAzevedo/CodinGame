using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestRunRectanglePartition
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var inputX = new List<int>() { 11, 25, 26, 29, 30, 40, 44, 56, 65, 71, 87, 98, 100, 108, 130, 149, 153, 161, 173, 179 };
            var inputY = new List<int>() { 1, 11, 16, 17, 19, 37, 38, 53, 65, 69 };
            var x = 200;
            var y = 100;

            var result = Solution.CalculateSquares(inputX, inputY, x, y);

            Assert.AreEqual(123, result);
        }
    }
}