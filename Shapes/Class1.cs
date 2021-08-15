using System;

namespace Shapes
{
    public class Triangle
    {
        double Aside, Bside, Cside;
        double AreaOfTriangle;
        double Perimeter;

        public Triangle(double a, double b, double c)
        {
            Aside = a;
            Bside = b;
            Cside = c;
        }

        private bool IfCorrectInput()
        {
            try
            {
                if (Aside <= 0 || Bside <= 0 || Cside <= 0)
                    throw new Exception("Стороны должны быть положительным числом");

                //сумма любых двух сторон должна быть больше третьей
                if ((Aside + Bside) <= Cside || (Aside + Cside) <= Bside || (Bside + Cside) <= Aside)
                {
                    throw new Exception("Треугольника с такими сторонами не существует");
                }

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
                return false;
            }
        }

        public double GetPerimeter()
        {
            if (IfCorrectInput())
                return Perimeter = Aside + Bside + Cside;
            else return 0;
        }
            
            
            
        
        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;

            if (IfCorrectInput())

            {
                //if (Perimeter > 0)
                // {
                AreaOfTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - Aside) * (halfPerimeter - Bside) *
                    (halfPerimeter - Cside));
                // }
                return AreaOfTriangle;
            }
            else return 0;
            
            
        }

        public bool IfRightTriangle() // true - треугольник прямоугольный, false - нет
        {
                if (Math.Pow(Cside, 2) == Math.Pow(Aside, 2) + Math.Pow(Bside, 2))
                    return true;
                else return false;
        }
        public void PrintPerimeter()
        {
            if (IfCorrectInput())
            Console.WriteLine($"Периметр треугольника равен {Perimeter}");
        }
        public void PrintArea()
        {
           if( IfCorrectInput())
            Console.WriteLine($"Площадь треугольника равна {AreaOfTriangle}");
        }
        public void PrintIfRightTriangle()
        {
            if(IfCorrectInput())
            if (IfRightTriangle())
                Console.WriteLine($"Треугольник со сторонами {Aside} {Bside} {Cside} является прямоугольным");
            else if(Perimeter>0)
                Console.WriteLine($"Треугольник со сторонами {Aside} {Bside} {Cside} НЕ является прямоугольным");
        }
        
    }

    public class Circle
    {
        double Radius;
        double AreaOfCircle;

        public Circle(double r)
        {
            Radius = r;
        }

        public double GetAreaOfCircle()
        {
            if(Radius>0)
            AreaOfCircle = Math.PI * Math.Pow(Radius, 2);
            return AreaOfCircle;
        }
        public void PrintAreaOfCircle()
        {
            try
            {
                if (Radius > 0)
                {
                    GetAreaOfCircle();
                    Console.WriteLine($"Площадь круга с радиусом {Radius} равна {AreaOfCircle}");
                }
                else
                    throw new Exception("Радиус должен быть положительным числом");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}") ;   
            }
            

        }
    }

}
