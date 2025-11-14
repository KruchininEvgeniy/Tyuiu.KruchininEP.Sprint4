using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KruchininEP.Sprint4.Task7.V21.Lib
{
    public class DataService : ISprint4Task7V21
    {
        public int Calculate(int rows, int columns, string value)
        {
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(i * columns + j, 1));
                }
            }
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }

            }

            return sum;
        }
    }
}