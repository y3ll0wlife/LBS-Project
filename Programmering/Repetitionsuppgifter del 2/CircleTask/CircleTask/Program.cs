using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circy = new Circle(11);
            Console.WriteLine(circy.GetArea());

            Circle circy2 = new Circle(4.44);
            Console.WriteLine(circy2.GetPerimeter());

            Console.ReadKey();
        }

        class Circle
        {
            public double Rad;

            public Circle(double rad)
            {
                Rad = rad;
            }

            public double GetPerimeter()
            {
                return 2 * Math.PI * Rad; 
            }


            public double GetArea()
            {
                return Math.PI * Math.Pow(Rad, 2);
            }
        }
    }
}
