using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA1_task2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Назовем дигитацией целого числа следующую процедуру
             * Сначала вычисляем сумму цифр числа. Если полученный результат больше числа 9, 
             * то повторяем эту процедуру, пока не получим цифру от 1 до 9. 
             * Найти результат дигитации числа N! (N < 1.000.000.000) 
            */

            int num = 0;
            int sum = 0;
            int factorial = 1;

            //Принимаем на вход значение согласно условию
            do
            {
                Console.WriteLine("Input value.. ");
                num = Convert.ToInt32(Console.ReadLine());
            } while ((num > 1000000000) || (num <= 0));

            //Вычисление дигитации факториала
            if (num <= 1)
            {
                Console.WriteLine("Result of digitation is: {0}", num);
            }
            else
            {
                //расчет факториала
                for (int i = num; i > 1; i--)
                {
                    factorial *= i;
                }

                //Вывод результата дигитации
                switch (num)
                {
                    case 2:
                        Console.WriteLine("Result of digitation is: {0}", factorial);
                        break;
                    case 3:
                        //Считаем поочередно сумму цифр введенного числа
                        while (factorial != 0)
                        {
                            sum += factorial % 10;
                            factorial /= 10;
                        }
                        Console.WriteLine("Result of digitation is: {0}", sum);
                        break;
                    case 4:
                        while (factorial != 0)
                        {
                            sum += factorial % 10;
                            factorial /= 10;
                        }
                        Console.WriteLine("Result of digitation is: {0}", sum);
                        break;
                    case 5:
                        while (factorial != 0)
                        {
                            sum += factorial % 10;
                            factorial /= 10;
                        }
                        Console.WriteLine("Result of digitation is: {0}", sum);
                        break;
                    default:
                        Console.WriteLine("Result of digitation is: 9");
                        break;
                }                
            }
            Console.ReadKey();
        }
    }
}
