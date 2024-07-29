using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Укажите радиус окружности r=");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Длина окружности {0:F2}, площадь круга {1:F2}", Circle.GetLength(r), Circle.GetArea(r));

                Console.Write("Укажите координаты центра окружности x0=");
                double x0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Укажите координаты центра окружности y0=");
                double y0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Укажите координаты точки x=");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Укажите координаты точки y=");
                double y = Convert.ToDouble(Console.ReadLine());

                if (Circle.IsPointInside(x, y, r, x0, y0) == true)
                    Console.WriteLine("Точка внутри окружности");
                else
                    Console.WriteLine("Точка вне окружности");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
            }

            Console.ReadKey();
        }
    }
}
