using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 0;
            Console.WriteLine("Input number");
            num = Convert.ToInt32(Console.ReadLine());
            int num2 = num % 100;
            int num3 = num / 100;
            Console.Write(num2);
            Console.WriteLine(num3);
            Console.WriteLine(n / 100 + n % 100 * 10); //Answer. Output through place holders
            Console.ReadLine();
            */

            /*Console.WriteLine("Enter destination");
            string destination = Console.ReadLine();

            switch (destination)
            {
                case "left":
                    Console.WriteLine("U turn left");
                    break;
                case "right":
                    Console.WriteLine("U turn right");
                    break;
                case "straght":
                    Console.WriteLine("U turn stright");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            */

            /*
            Console.WriteLine("Hi. Make your choise");
            int answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                case 7:
                    Console.WriteLine("Raise balance");
                    break;
                case 2:
                case 10:
                case 11:
                    Console.WriteLine("Check your balance");
                    break;
                case 3:
                    Console.WriteLine("Account info");
                    break;
                case 4:
                    Console.WriteLine("Exit to previous menu");
                    break;
                default:
                    Console.WriteLine("Wrong choise");
                    break;
            }

            //ConsoleColor color = ConsoleColor.DarkBlue;
            */

            /*
            int x = 16;

            while (x >= 6)
            {
                Console.WriteLine(x);
                x -= 2;
            }

            int i = 10;

            Console.WriteLine(" ");

            do
            {
                Console.WriteLine(i);
                i--;

            } while (i >= 1);

            Console.ReadLine();
            */

            /*
            int b = 0;
            for (int a = 0; a <= 10; a++)
            {
                b += a;
            }
            Console.WriteLine(b);
            */



            //simple numbers counting less than 200000000
            //1000000007
            

            int s = 0;
            s = Convert.ToInt32(Console.ReadLine());

                if ((s / s == 1) && (s / 1 == s))
                {
                    Console.WriteLine("Simple");
                }
                else
                {
                    Console.WriteLine("Non Simple");
                }         

            Console.ReadKey();

            //HOMETASK
            "Вычислить сумму цифр произвольного положительного числа N. (N < 1000000000)"
                "Пример: N = 1234   Ответ: 10"
            "Вычислить количество единиц в двоичной записи произвольного положительного числа N. (N < 1000000000)"
                "Пример N=15   Ответ: 4"
            
            "Назрвем дигитацией целого числа следующую процедуру. Сначала вычисляем сумуму цифр числа. Если полученный результат больше 9, то повторяем процедуру, пока не получим цифру от 1 до 9. Найти результат дигитации числа N. (N < 1000000000)"
                "N = 4 Ответ 6"
                "4! = 24; 2 + 4 == "


        }
    }
}
