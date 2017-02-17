using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Triangle
    {

        public double a;
        public readonly Points p1;
        public readonly Points p2;
        public readonly Points p3;
        public readonly Edge AB;
        public readonly Edge BC;
        public readonly Edge CA;

        public Triangle(Points p1, Points p2, Points p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;

            AB = new Edge(p1, p2);
            BC = new Edge(p2, p3);
            CA = new Edge(p3, p1);

        }

        public bool CheckReal//Существование 
        {
            get
            {
                if (AB.lenght + BC.lenght <= CA.lenght || AB.lenght + CA.lenght <= BC.lenght || BC.lenght + CA.lenght <= AB.lenght)
                {
                    Console.WriteLine("Треугольник не существует");
                    return false;
                }
                return true;
            }
        }

        public double Perimetre
        {
            get
            {
                return (AB.lenght + BC.lenght + CA.lenght);
            }
        }

        public double Area
        {
            get
            {
                double p = Perimetre / 2;
                return (Math.Sqrt(p * (p - AB.lenght) * (p - BC.lenght) * (p - CA.lenght)));
            }
        }

        public bool Isosceles
        {
            get
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
        }

        public bool CheckRight
        {
            get
            {
                if ((Math.Round(Area, 2) == Math.Round(AB.lenght * BC.lenght / 2, 2))
                || (Math.Round(Area, 2) == Math.Round(CA.lenght * BC.lenght / 2, 2))
                || (Math.Round(Area, 2) == Math.Round(AB.lenght * CA.lenght / 2, 2)))
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
        }
    }
}