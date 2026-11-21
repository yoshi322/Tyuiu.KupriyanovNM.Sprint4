using Tyuiu.KupriyanovNM.Sprint4.Task5.V1.Lib;
namespace Tyuiu.KupriyanovNM.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] {
                { -4,  3, -2,  4, -5 },
                {  5, -4,  5, -6,  6 },
                { -6,  2, -3,  6, -5 },
                {  6, -2,  3, -6,  4 },
                { -6,  2, -6,  6, -2 }
            };

            int[,] res = ds.Calculate(mas2);

            int[,] wait = new int[5, 5] {
                { -4,  1, -2,  1, -5 },
                {  1, -4,  1, -6,  1 },
                { -6,  1, -3,  1, -5 },
                {  1, -2,  1, -6,  1 },
                { -6,  1, -6,  1, -2 }
            };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
