using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System;

namespace ShapeTests
{
    [TestClass]
    public class UnitTestsShapes
    {
        [TestMethod]
        public void FindTriangleArea_normalNums_TriangleArea()//���� ���� ������������� �����
        {
            //����������� ��������, ��� ����� 2� ����� ������ ��-�� ������ �������
            Triangle tr = new Triangle(3, 4, 5);

            double expected = 6;
            double actual = tr.GetArea();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception), "������������ � ������ ��������� �� ����������")]
        public void FindTriangleArea_TriangleNotExist_TriangleArea()//���� ���� ������������� �����
        {
            //�� ����������� ��������, ��� ����� 2� ����� ������ ��-�� ������ �������
            Triangle tr = new Triangle(6, 14, 7);

            double actual = tr.GetArea();
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "������� ������ ���� ������������� ������")]
        public void FindTriangleArea_NotPositiveSide_Exception()//���� �������������� ����� ��� 0 � ���� �� ������
        {
            Triangle tr = new Triangle(-3, 0, 5);
            double actual = tr.GetArea();

        }

        [TestMethod]
        public void FindCircleArea_regularNum_CircleArea()//���� �������������� �����
        {
            Circle c = new Circle(15);
            double expected = 706.86;
            double actual = Math.Round(c.GetAreaOfCircle(), 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "������ ������ ���� ������������� ������")]
        public void FindCircleArea_NotPositiveNum_Exception()//���� �������������� ����� ��� 0
        {
            Circle c = new Circle(0);
            double actual = c.GetAreaOfCircle();
        }
    }
}
