using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_For_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array2 = { 1, -2, -3, -4, -5, -6, -7, -8, -9, 10 };
            int[,] array3 = { { 1, 2, 3, 4, 5, 6, 7, 8, 9, 150 }, { 1, 2, -3, 4, 5, 6, 7, 8, 9, 10 } };

            Console.WriteLine(MethodForCheckingIntegers(array));
            Console.WriteLine(MethodForSumArrayElements(array));
            Console.WriteLine(MethodForWritePositiveArrayElements(array2));
            Console.WriteLine(MethodForCountingMultMinMax(array3));
            MethodForSingleMatrixPrinting(15);
            Console.ReadKey();
        }

        static int MethodForCheckingIntegers(int [] a)
        {
            //Method for counting number of even elements in the array
            int count = 0;
            
            for (int i = 0; i < a.Length; i++)            
                if (a[i] %2 == 0)                
                    count += 1;                
            
            return count;
        }

        static int MethodForSumArrayElements(int [] a)
        {
            //Method for getting the sum of all elements in the array
            int count = 0;

            for (int i = 0; i < a.Length; i++)
                count += a[i];
            
            return count;
        }

        static int MethodForWritePositiveArrayElements(int [] a)
        {
            //Method for counting all positive elements of the array            
            int count = 0;

            for (int i = 0; i < a.Length; i++)            
                if (a[i] > 0)                                    
                    count += a[i];            

            return count;
        }

        static double MethodForCountingMultMinMax(int [,] a)
        {
            //Method for counting multiplication min and max values
            double min = a[0,0];
            double max = a[0,0];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    double s = a[i, j];

                    if (s > max)                    
                        max = s;                    

                    if (s < min)                    
                        min = s;                                                               
                }
            }
            return max * min;
        }

        static void MethodForSingleMatrixPrinting(int a)
        {
            //Method for printing single matrix
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    if (i != j)                    
                        Console.Write("{0,2}", 0);                    
                    else                    
                        Console.Write("{0,2}", 1);                    
                }
                Console.WriteLine();
            }
        }
    }
}
