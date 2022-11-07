using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.   Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
                метод, определяющий длину окружности по заданному радиусу;
                метод, определяющий площадь круга по заданному радиусу;
                метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
             */
            Console.Write("Введите радиус r круга. r = ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nДлина окружности равна {0}.", Сircle.СircleLength(r));
            Console.WriteLine("Площадь круга равна {0}.", Сircle.СircleArea(r));

            Console.Write("\nВведите коодинату x точки. x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коодинату y точки. y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nВведите коодинату x0 центра круга. x0 = ");
            double x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коодинату y0 центра круга. y0 = ");
            double y0 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Сircle.PointBelongСircle(x, y, r, x0, y0);
            Console.ReadKey();
        }
    }
}
