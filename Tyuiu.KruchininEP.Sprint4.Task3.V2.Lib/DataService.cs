using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KruchininEP.Sprint4.Task3.V2.Lib
{
    public class DataService : ISprint4Task3V2
    {
        public int Calculate(int[,] array)
        {

            int rows = 5;
            int colums = 5;

            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}