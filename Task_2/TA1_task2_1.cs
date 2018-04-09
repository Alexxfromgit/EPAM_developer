using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1_task2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить сумму цифр произвольного положительного числа N. (N < 1.000.000.000)

            int num = 0;
            int sum = 0;

            //Принимаем на вход значение согласно условию
            do
            {
                Console.WriteLine("Input value.. ");
                num = Convert.ToInt32(Console.ReadLine());
            } while ((num > 1000000000) || (num <= 0));

            //Считаем поочередно сумму цифр введенного числа
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            
            //Вывод результата
            Console.WriteLine("sum of value numbers is {0}", sum);
            Console.ReadKey();
        }
    }
}
