using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1_task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить количество единиц в двоичной записи произвольного положительного числа N. (N < 1.000.000.000)
            int num = 0;
            int sum = 0;

            //Принимаем на вход значение согласно условию
            do
            {
                Console.WriteLine("Input value.. ");
                num = Convert.ToInt32(Console.ReadLine());
            } while ((num > 1000000000) || (num <= 0));

            //Перевод в двоичную систему
            string answer = "";

            while (num != 0)
            {
                if (num != ((num / 2) * 2))
                {
                    answer = "1" + answer;
                    sum += 1;
                }
                else
                {
                    answer = "0" + answer;
                }

                num /= 2;
            }

            //Вывод результатов
            Console.WriteLine("Converted number to binary is ");
            Console.WriteLine(answer);
            Console.WriteLine("Sum of 1 in the binary number is ");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
