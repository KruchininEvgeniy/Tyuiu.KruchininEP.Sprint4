using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KruchininEP.Sprint4.Task0.V4.Lib
{
    public class DataService : ISprint4Task0V4
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int result = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result *= array[i];
                }
            }
            return result;
        }
    }
}