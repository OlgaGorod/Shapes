using System;
using Shapes;

namespace GetShapesConsole
{
    class Program
    {
        static void Main()
        {
            // треугольник
            string[] sidesStr = new string[3];
            string input;
            double[] sides = new double[3];
            bool haveSides = false; //1-стороны заданы, 0 - не заданы


            Console.WriteLine("Введите стороны треугольника через пробел");
            input = Console.ReadLine();

            try
            {
                sidesStr = input.Split(" ");

                for (int i = 0; i < 3; i++)
                    sides[i] = Convert.ToDouble(sidesStr[i]);
                haveSides = true;
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }

            if (haveSides)//если стороны заданы
            {
                Triangle tr = new Triangle(sides[0], sides[1], sides[2]);
                tr.PrintArea();
                tr.PrintPerimeter();
                tr.PrintIfRightTriangle();
                //Вызывать лучше по отдельности, а то при возниконовении ошибки она выводится несколько раз
            }


            //круг
            double r;
            Console.WriteLine("Введите радиус круга");

            try
            {
                r = Convert.ToDouble(Console.ReadLine());
                Circle c = new Circle(r);
                c.PrintAreaOfCircle();
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}
