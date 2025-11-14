using System;
using Tyuiu.KruchininEP.Sprint4.Task7.V21.Lib;

namespace Tyuiu.KruchininEP.Sprint4.Task7.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Кручинин Е. П.| РППб25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Добавление к решению итоговых проектов по спринту                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Кручинин Е. П.| РППб25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 425963128528. Преобразуйте ее в       *");
            Console.WriteLine("* матрицу 4 на 3 и подсчитайте сумму четных чисел.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 4;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            string str = "425963128528";

            DataService ds = new DataService();

            Console.WriteLine("Матрица");
            Console.WriteLine();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mtrx[i, j] = int.Parse(str.Substring(i * 3 + j, 1));
                    Console.Write("   " + mtrx[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(rows, columns, str);



            Console.WriteLine("Сумма четных чисел = " + res);

            Console.ReadKey();
        }
    }
}