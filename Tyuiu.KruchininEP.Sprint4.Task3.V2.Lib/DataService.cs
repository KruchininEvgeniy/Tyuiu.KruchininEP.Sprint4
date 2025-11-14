namespace Tyuiu.KruchininEP.Sprint4.Task3.V2.Lib
{
    public class DataService
    {
        public int GetMaxInFirstRow(int[,] array)
        {
            int max = array[0, 0];

            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[0, i] > max)
                {
                    max = array[0, i];
                }
            }

            return max;
        }
    }
}
