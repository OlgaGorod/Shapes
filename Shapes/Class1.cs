using System;

namespace Shapes
{
    /* abstract class Shape
     {
         protected double AreaOfShape;
         protected double Perimeter;

     }*/
    public class Triangle //: Shape
    {
        double aSide, bSide, cSide;
        double AreaOfShape;
        double Perimeter;

        public Triangle(double a, double b, double c)
        {
            aSide = a;
            bSide = b;
            cSide = c;
        }

        public double GetPerimeter()
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
            {
                Console.WriteLine("Стороны должны быть положительным числом");
                //throw new Exception("Стороны должны быть положительным числом");
                return 0;
            }

            //сумма двух сторон треугольника всегда больше третьей стороны
            if ((aSide + bSide) <= cSide || (aSide + cSide) <= bSide || (bSide + cSide) <= aSide)
            {
                Console.WriteLine("Треугольника с такими сторонами не существует");
                //throw new Exception("Треугольника с такими сторонами не существует");
                return 0;
            }
            
            
            return Perimeter = aSide + bSide + cSide;
        }
        public double GetArea()
        {
            double halfPerimeter = GetPerimeter() / 2;
            if (Perimeter > 0)
            {
                AreaOfShape = Math.Sqrt(halfPerimeter * (halfPerimeter - aSide) * (halfPerimeter - bSide) *
                    (halfPerimeter - cSide));
            }
            
            return AreaOfShape;
        }

        public bool IfRightTriangle() // true - треугольник прямоугольный, false - нет
        {
                if (Math.Pow(cSide, 2) == Math.Pow(aSide, 2) + Math.Pow(bSide, 2))
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
            Console.WriteLine($"Площадь треугольника равна {AreaOfShape}");
        }
        public void PrintIfRightTriangle()
        {
            if (IfRightTriangle())
                Console.WriteLine($"Треугольник со сторонами {aSide} {bSide} {cSide} является прямоугольным");
            else if(Perimeter>0)
                Console.WriteLine($"Треугольник со сторонами {aSide} {bSide} {cSide} НЕ является прямоугольным");
        }
        
    }

    public class Circle
    {

    }

}
