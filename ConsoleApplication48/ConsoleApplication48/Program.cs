using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{
    class Program
    {

        static void Main(string[] args)
        {

            Triangle[] ArrayOfTriangles = new Triangle[6];

            var p1 = new Points(0, 0);
            var p2 = new Points(0, 0);
            var p3 = new Points(0, 0);

            double SumPerimetre = 0;
            double CounterPerimetre = 0;
            double SumArea = 0;
            double CounterArea = 0;

            double[] x1 = { 5, 0, 1, 6, 2, 0 };
            double[] y1 = { 3, 0, 2, 5, 4, 0 };

            double[] x2 = { 2, 1, 3, 4, 6, 1 };
            double[] y2 = { 2, 0, 4, 3, 8, 0 };

            double[] x3 = { 5, 0, 5, 2, 10, 0 };
            double[] y3 = { 2, 1, 6, 1, 12, 1 };

            for (int i = 0; i < 6; i++)
            {

                ArrayOfTriangles[i] = new Triangle(
                p1 = new Points(x1[i], y1[i]),
                p2 = new Points(x2[i], y2[i]),
                p3 = new Points(x3[i], y3[i]));

            }

            for (int i = 0; i < ArrayOfTriangles.Length; i++)
            {
                Console.WriteLine("*************************************");
                Console.WriteLine("Треугольник - {0}", i + 1);

                if (ArrayOfTriangles[i].CheckReal)
                {

                    Console.WriteLine("Периметр = " + ArrayOfTriangles[i].Perimetre);
                    Console.WriteLine("Площадь = " + ArrayOfTriangles[i].Area);

                    if (ArrayOfTriangles[i].Isosceles)
                    {
                        SumArea += ArrayOfTriangles[i].Area;
                        CounterArea++;
                    }

                    if (ArrayOfTriangles[i].CheckRight)
                    {
                        SumPerimetre += ArrayOfTriangles[i].Perimetre;
                        CounterPerimetre++;
                    }
                }
                else
                      Console.WriteLine("Треугольник не существует");
            }

            Console.WriteLine("*************************************");
            Console.WriteLine("Средний периметр = " + SumPerimetre / CounterPerimetre);
            Console.WriteLine("Средняя площадь = " + SumArea / CounterArea);

        }
    }
}
