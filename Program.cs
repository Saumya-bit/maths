using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestMSExercise45
{
    [TestClass]
    public class UnitTest1
    {
        private double squareNo;
        private double cubeNo;

        [TestMethod]
        public void TestMethod1()
        {
            maths.Calculation objc = new maths.Calculation();
            double num1 = 24;
            double squareNO = num1 * num1;
            double squarerootNo = Math.Sqrt(num1);
            double cubeNO = num1 * num1 * num1;

            Assert.AreEqual(squareNo, objc.Square(num1));
            Assert.AreEqual(squarerootNo, objc.SquareRoot(num1));
            Assert.AreEqual(cubeNo, objc.Cube(num1));

        }
    }
}