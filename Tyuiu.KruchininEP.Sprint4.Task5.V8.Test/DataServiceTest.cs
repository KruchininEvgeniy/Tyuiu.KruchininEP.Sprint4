using Tyuiu.KruchininEP.Sprint4.Task5.V8.Lib;

namespace Tyuiu.KruchininEP.Sprint4.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mas = new int[5, 5]
            {
                {6, 3, 6, 6, -7 },
                { 9, -8, 9, 7, 9},
                {5, 6, 8, -7, 5},
                { 8, 5, -6, 5, 3},
                { 3, -9, 9, 8, 8}
            };
            int[,] masWait = new int[5, 5]
            {
                {6, 3, 6, 6, 0 },
                { 9, 0, 9, 7, 9},
                {5, 6, 8, 0, 5},
                { 8, 5, 0, 5, 3},
                { 3, 0, 9, 8, 8}
            };
            CollectionAssert.AreEqual(masWait, ds.Calculate(mas));
        }
    }
}