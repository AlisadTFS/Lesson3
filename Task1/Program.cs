using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов массива: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arrayint = new int[n, m];
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int y = 0; y < m; y++ )
                {
                    arrayint[i, y] = rand.Next(100);
                    Console.Write($" {arrayint[i, y].ToString("d2")} ");
                }
                Console.WriteLine();
            }
            if (n > m)
            {
                n = m;
            }
            else
            {
                m = n;
            }            
            for (int i = 0; i < n; i++)
            {                
                for (int y = 0; y < m; y++)
                {
                    if ((i == y) || (i == (m-y-1)))
                    {
                        Console.Write($" {arrayint[i, y].ToString("d2")} ");
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
