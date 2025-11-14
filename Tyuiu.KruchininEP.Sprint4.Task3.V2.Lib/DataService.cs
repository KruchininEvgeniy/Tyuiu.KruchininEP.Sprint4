using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KruchininEP.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            int summ = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 1)
                    {
                        summ += array[i, j];
                    }
                }
            }
            return summ;
        }
    }
}