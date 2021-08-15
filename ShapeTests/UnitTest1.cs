using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;

namespace ShapeTests
{
    [TestClass]
    public class UnitTestsShapes
    {
        [TestMethod]
        public void FindTriangleArea_normalNums_TriangleArea()//ввод трех положительных чисел
        {
            //выполняется свойство, что сумма 2х любых сторон тр-ка больше третьей
            Triangle tr = new Triangle(3, 4, 5);

            double expected = 6;
            double actual = tr.GetArea();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "Треугольника с такими сторонами не существует")]
        public void FindTriangleArea_TriangleNotExist_TriangleArea()//ввод трех положительных чисел
        {
            //НЕ выполняется свойство, что сумма 2х любых сторон тр-ка больше третьей
            Triangle tr = new Triangle(6, 14, 7);

            double actual = tr.GetArea();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Стороны должны быть положительным числом")]
        public void FindTriangleArea_NotPositiveSide_Exception()//ввод отрицательного числа или 0 в одну из сторон
        {
            Triangle tr = new Triangle(-3, 0, 5);
            double actual = tr.GetArea();

        }

        [TestMethod]
        public void FindCircleArea_regularNum_CircleArea()//ввод положительного числа
        {
            Circle c = new Circle(15);
            double expected = 706.86;
            double actual = Math.Round(c.GetAreaOfCircle(), 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Радиус должен быть положительным числом")]
        public void FindCircleArea_NotPositiveNum_Exception()//ввод отрицательного числа или 0
        {
            Circle c = new Circle(0);
            double actual = c.GetAreaOfCircle();
        }
    }
}
