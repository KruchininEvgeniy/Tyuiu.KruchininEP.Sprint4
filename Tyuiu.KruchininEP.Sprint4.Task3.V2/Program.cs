using System;
using Tyuiu.KruchininEP.Sprint4.Task3.V2.Lib;

namespace Tyuiu.KruchininEP.Sprint4.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                {4, 3, 2, 8, 7},
                {4, 6, 5, 5, 7},
                {3, 8, 8, 3, 5},
                {5, 7, 5, 4, 4},
                {8, 8, 3, 7, 6}
            };

            DataService ds = new DataService();
            int max = ds.GetMaxInFirstRow(array);

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "\t");
                Console.WriteLine();
            }

            Console.WriteLine($"\nМаксимальный элемент в первой строке: {max}");
            Console.ReadLine();
        }
    }
}
