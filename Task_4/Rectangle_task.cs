using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_task
{
    class Rectangle
    {
        private double sideA { get; set; }
        private double sideB { get; set; }
        
        public double GetSideA() //First method for working with sideA
        {
            return sideA;
        }
        
        public double GetSideB() //Second method for working with sideB
        {
            return sideB;
        }

        public Rectangle() //Without parameters constructor
        {
            sideA = 3;
            sideB = 4;
        }
        
        public Rectangle(double sideA) //With 1 parameter constructor
        {
            this.sideA = sideA;
            sideB = 5;
        }
                
        public Rectangle(double sideA, double sideB) //With 2 parameters constructor
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
                
        public double Area() //Method for calculating area
        {
            return sideA * sideB;
        }
                
        public double Perimeter() //Method for calculating perimeter
        {
            return sideA + sideB;
        }
                
        public bool IsSquare() //Method for calculating squares
        {
            if (sideA == sideB)            
                return true;            
            else            
                return false;            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Creating the array of class objects
            Rectangle[] newRectangle = new Rectangle[10];
            
            //Fill the array with class objects
            for (int i = 0; i < newRectangle.Length; i++)
            {
                int k = newRectangle.Length / 3;
                int l = newRectangle.Length - 2 * k;
                if (i < k)
                {
                    newRectangle[i] = new Rectangle(8, 4);
                }
                else if (i < k*2)
                {
                    newRectangle[i] = new Rectangle(5);
                }
                else
                {
                    newRectangle[i] = new Rectangle();
                }                
            }            
                        
            //The smallest Perimeter
            int count = 0;
            double perim = 0;
            double value = newRectangle[0].Perimeter();
            for (int i = 0; i < newRectangle.Length; i++)
            {
                perim = newRectangle[i].Perimeter();

                if (value > perim)
                {
                    count = i;
                    value = perim;
                }
            }
            Console.WriteLine("Smallest perimeter is {0}", newRectangle[count].Perimeter());

            //The biggest Area
            int count2 = 0;
            double area = 0;
            double value2 = newRectangle[0].Area();

            for (int i = 0; i < newRectangle.Length; i++)
            {
                area = newRectangle[i].Area();
                if (area > value2)
                {
                    count2 = i;
                    value2 = area;
                }
                    
            }
            Console.WriteLine("Biggest area is {0}", newRectangle[count2].Area());

            int count3 = 0;
            for (int i = 0; i < newRectangle.Length; i++)
            {
                if (newRectangle[i].IsSquare() == true)
                {
                    Console.WriteLine("Number of square rectangle is: {0}", i);
                    count3++;
                }
            }

            if (count3 == 0)
            {
                Console.WriteLine("Number of square is null");
            }          

            Console.ReadKey();
        }
    }
}
