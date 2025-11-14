using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KruchininEP.Sprint4.Task3.V2.Lib;

namespace Tyuiu.KruchininEP.Sprint4.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
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
            int result = ds.GetMaxInFirstRow(array);

            Assert.AreEqual(8, result); 
        }
    }
}
