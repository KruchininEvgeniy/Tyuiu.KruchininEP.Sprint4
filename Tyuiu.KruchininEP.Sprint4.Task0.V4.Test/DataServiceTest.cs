using Tyuiu.KruchininEP.Sprint4.Task0.V4.Lib;

namespace Tyuiu.OvsepyanAA.Sprint4.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service = new();
            int[] array = new int[] { 5, 3, 7, 1, 3, 9, 8, 7, 9, 4 };
            Assert.AreEqual(32, service.GetMultEvenArrEl(array));

        }
    }
}