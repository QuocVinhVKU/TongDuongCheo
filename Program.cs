using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Moi ban nhap so dong/cot cua ma tran vuong: ");
            int x = int.Parse(Console.ReadLine());
           
            int y = x;

            int[,] arr = new int[x, y];
            int sum = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" Moi ban nhap phan tu IntArray[{0}, {1}] = ", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                    if (i == j) sum += arr[i, j];
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(" " + arr[i,j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Tong duong cheo la " + sum);

            Console.ReadKey();
        }
    }
}







