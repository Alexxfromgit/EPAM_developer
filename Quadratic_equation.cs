using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            double x = 0;
            double x1 = 0;
            double x2 = 0;

            //Input values for quation
            Console.WriteLine("Quadratic Equation like ax2 + bx + c = 0");
            Console.Write("Input value a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input value b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Input value c = ");
            c = Convert.ToDouble(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;

            if (d == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("Answer x = " + x);
            }
            else if (d > 0)
            {
                x1 = (-b - Math.Sqrt(d)) / (2 * a);
                x2 = (-b + Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Answer x1 = " + x1 + ", Answer x2 = " + x2);
            }
            else
            {
                double real_root = -b / (2 * a);

                double no_real_root = Math.Sqrt(-d) / (2 * a);

                Console.WriteLine("Answer x1 = " + real_root + " + i * " + no_real_root);
                Console.WriteLine("Answer x2 = " + real_root + " - i * " + no_real_root);
            }

            Console.ReadLine();
        }
    }
}
