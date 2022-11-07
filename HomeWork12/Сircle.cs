using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    static class Сircle
    {
       static public double СircleLength(double r)
       {
            return 2 * r * Math.PI;
       }
        static public double  СircleArea(double r)
        {
            return r * r * Math.PI;
        }
        static public void PointBelongСircle( double x, double y,double r, double x0, double y0)
        {
            if (Math.Sqrt(Math.Pow(x-x0,2)+ Math.Pow(y - y0, 2)) <r)
            {
                Console.WriteLine("Точка с координатами ({0},{1}) принадлежит кругу с центром в ({2},{3}) и радиусом {4}.", x,y, x0, y0,r);
            }
            else
            {
                Console.WriteLine("Точка с координатами ({0},{1}) НЕ принадлежит кругу с центром в ({2},{3}) и радиусом {4}.", x, y, x0, y0, r);
            }
            
        }
    }
}
