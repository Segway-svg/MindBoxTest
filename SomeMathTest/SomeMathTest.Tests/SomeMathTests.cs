using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeMath.Figures;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace SomeMathTest.Tests
{
    [TestClass]
    public class SomeMathTests
    {
        [TestMethod]
        public void FindCircleArea_Radius5_SuccessOutput()
        {
            // arrange
            double r = 5; 
            double expected = 78.5;
            Circle circle = new Circle(r);

            // act
            double circleArea = circle.CalculateArea();

            // assert
            Assert.AreEqual(circleArea, expected);
        }

        [TestMethod]
        public void FindCircleArea_RadiusNegative5_FailOutput()
        {
            // arrange
            int r = -5;

            // act & assert
            try
            {
                Circle circle = new Circle(-5);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void FindTriangleArea_A5andB12andC13_CorrectOutput()
        {
            // arrange
            double a = 5;
            double b = 12;
            double c = 13;
            double expected = 30;
            Triangle triangle = new Triangle(a, b, c);

            // act
            double triangleArea = triangle.CalculateArea();

            // assert
            Assert.AreEqual(triangleArea, expected);
        }

        [TestMethod]
        public void FindTriangleArea_A0andB1andC2_CorrectOutput()
        {
            // arrange
            int a = 0;
            int b = 0;
            int c = 0;

            // act & assert
            try
            {
                Triangle triangle = new Triangle(0, 1, 2);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.GetType() == typeof(ArgumentException));
            }
        }

        [TestMethod]
        public void IsTriangleRectangle_A3andB4andC5_True()
        {
            // arrange
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;

            // act
            bool isTriangle = triangle.IsTriangleRectangle();

            // assert
            Assert.AreEqual(isTriangle, expected);
        }

        [TestMethod]
        public void IsTriangleRectangle_A1andB2andC3_False()
        {
            // arrange
            Triangle triangle = new Triangle(1, 2, 3);
            bool expected = true;

            // act
            bool isTriangle = triangle.IsTriangleRectangle();

            // assert
            Assert.AreNotEqual(isTriangle, expected);
        }
    }
}