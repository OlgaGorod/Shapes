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

        public double GetPerimeter()
        {
            if (Aside <= 0 || Bside <= 0 || Cside <= 0)
            {
                Console.WriteLine("Стороны должны быть положительным числом");
                //throw new Exception("Стороны должны быть положительным числом");
                return 0;
            }

            //сумма двух сторон треугольника всегда больше третьей стороны
            if ((Aside + Bside) <= Cside || (Aside + Cside) <= Bside || (Bside + Cside) <= Aside)
            {
                Console.WriteLine("Треугольника с такими сторонами не существует");
                //throw new Exception("Треугольника с такими сторонами не существует");
                return 0;
            }
            
            
            return Perimeter = Aside + Bside + Cside;
        }
        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            if (Perimeter > 0)
            {
                AreaOfTriangle = Math.Sqrt(halfPerimeter * (halfPerimeter - Aside) * (halfPerimeter - Bside) *
                    (halfPerimeter - Cside));
            }
            
            return AreaOfTriangle;
        }

        public bool IfRightTriangle() // true - треугольник прямоугольный, false - нет
        {
                if (Math.Pow(Cside, 2) == Math.Pow(Aside, 2) + Math.Pow(Bside, 2))
                    return true;
                else return false;
        }
        public void PrintPerimeter()
        {
            if (GetPerimeter()>0)
            Console.WriteLine($"Периметр треугольника равен {Perimeter}");
        }
        public void PrintArea()
        {
           if( GetArea()>0)
            Console.WriteLine($"Площадь треугольника равна {AreaOfTriangle}");
        }
        public void PrintIfRightTriangle()
        {
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
            if (Radius > 0)
            {
                GetAreaOfCircle();
                Console.WriteLine($"Площадь круга с радиусом {Radius} равна {AreaOfCircle}");
            }
            else
                Console.WriteLine("Радиус должен быть положительным числом");
        }
    }

}
