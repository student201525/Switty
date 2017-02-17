using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    class Points
    {
        public readonly double x, y;
        public Points(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Edge
    {
        public Points v1;
        public Points v2;
        public double lenght;
        public Edge(Points v1, Points v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            lenght = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
        }

    }

    class Triangle
    {

        public double a;
        Points p1;
        Points p2;
        Points p3;
        Edge AB;
        Edge BC;
        Edge CA;
        public Triangle(Points p1, Points p2, Points p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            AB = new Edge(p1, p2);
            BC = new Edge(p2, p3);
            CA = new Edge(p3, p1);


        }

        public bool CheckReal()//Существование 
        {

            if (AB.lenght + BC.lenght <= CA.lenght || AB.lenght + CA.lenght <= BC.lenght || BC.lenght + CA.lenght <= AB.lenght)
            {
                Console.WriteLine("Треугольник не существует");
              // Environment.Exit(0);
                return false;
            }
            return true;
        }

        public double GetPerimetre()//Периметр 
        {
          
                double primente = AB.lenght + BC.lenght + CA.lenght;
                a = primente;
               return primente;
            
        }

        public double GetArea()//Площадь 
        {
                double p = a / 2;
                double area = Math.Sqrt(p * (p - AB.lenght) * (p - BC.lenght) * (p - CA.lenght));//gerona 
                return area;
        }

        public bool CheckIsosceles()//Равнобедренность 
        {

            if (AB.lenght == BC.lenght || AB.lenght == CA.lenght || BC.lenght == CA.lenght)
            {
                Console.WriteLine("Треугольник равнобедренный");
                return true;
            }
            else
            {
                Console.WriteLine("Треугольник не равнобедренный");
                return false;
            }
        }

        public bool CheckRight()
        {
            if ((Math.Round(GetArea(), 2) == Math.Round(AB.lenght * BC.lenght / 2, 2))
            || (Math.Round(GetArea(), 2) == Math.Round(CA.lenght * BC.lenght / 2, 2))
            || (Math.Round(GetArea(), 2) == Math.Round(AB.lenght * CA.lenght / 2, 2)))

            {
                Console.WriteLine("Этот треугольник прямоугольный");
                return true;
            }
            else
            {
                Console.WriteLine("Этот треугольник не прямоугольный");
                return false;
            }
        }

        
        //public bool CheckRight()//Прямоугольность 
        //{
        //    if (Math.Pow(AB.lenght, 2) + Math.Pow(BC.lenght, 2) == Math.Pow(CA.lenght, 2)
        //        || Math.Pow(AB.lenght, 2) + Math.Pow(CA.lenght, 2) == Math.Pow(BC.lenght, 2) 
        //        || Math.Pow(CA.lenght, 2) + Math.Pow(BC.lenght, 2) == Math.Pow(AB.lenght, 2))
        //    {
        //        Console.WriteLine("Этот треугольник прямоугольный");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Этот треугольник не прямоугольный");
        //        return false;
        //    }
        //}
    }
}