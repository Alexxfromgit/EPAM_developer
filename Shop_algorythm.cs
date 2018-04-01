using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input money value
            double money = 0;

            Console.WriteLine("Input how much money do you have.. ");
            money = Convert.ToDouble(Console.ReadLine());

            //Quantity of products
            Console.WriteLine("Input quantity of products.. ");
            int product_quantity = Convert.ToInt32(Console.ReadLine());

            string product = " ";
            int quantity = 0;
            double price = 0;
            double count = 0;

            for (int i = 0; i < product_quantity; i++)
            {
                //Input products and count their summ
                //Input name. String parameter

                Console.WriteLine("Input what product do you wanna buy.. ");
                product += Console.ReadLine() + " ";

                //Input quantity. Int parameter
                Console.WriteLine("Input quantity of product.. ");
                quantity = Convert.ToInt32(Console.ReadLine());

                //Input price. Double parameter
                Console.WriteLine("Input price of product.. ");
                price = Convert.ToDouble(Console.ReadLine());

                //Counting summ
                count += quantity * price;
            }

            //Calculating
            double result = 0;

            result = money - count;

            if (result < 0)
            {
                Console.WriteLine("No enough money.. Sorry " + result);
            }
            else
            {
                Console.WriteLine("Your change is.. " + result);
                Console.WriteLine("You will buy" + product);
            }

            Console.ReadLine();
        }
    }
}
