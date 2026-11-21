using Tyuiu.KupriyanovNM.Sprint4.Task7.V14.Lib;
namespace Tyuiu.KupriyanovNM.Sprint4.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 4;
            string str = "458712659137";

            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 38;

            Assert.AreEqual(wait, res);
        }
    }
}
