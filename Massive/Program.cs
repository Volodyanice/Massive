using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 5;
            int[,] array = GetArray(n, m);
            PrintArray(array);
            Console.WriteLine();
        }

        static public void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for ( int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }    
        }

        static public int[,]  GetArray(int m, int n)
        {
            var number = new int[n, m];
            for (int i = 0; i < number.GetLength(0);i++)
            {
                for (int j = 0;j < number.GetLength(1);j++)
                {
                    number[i, j] = 1 + i * n +i%2 * (n - 2 * j - 1) + j;
                }
            }
            return number;
        }   
    }
}
