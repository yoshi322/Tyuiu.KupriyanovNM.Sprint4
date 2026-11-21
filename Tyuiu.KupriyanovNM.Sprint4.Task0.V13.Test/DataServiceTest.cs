using Tyuiu.KupriyanovNM.Sprint4.Task0.V13.Lib;

namespace Tyuiu.KupriyanovNM.Sprint4.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 6, 2, 3, 4, 5, 4, 9, 7, 8 };
            int res = ds.GetSumEvenArrEl(numsArray);

            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}
