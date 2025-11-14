using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KruchininEP.Sprint4.Task3.V2.Lib;

public class DataService : ISprint4Task3V2
{
    public int Calculate(int[,] array)
    {
        int max = array[0, 0];
        for (int j = 0; j < 5; j++)
        {
            if (array[0, j] > max)
            {
                max = array[0, j];
            }
        }
        return max;
    }
}