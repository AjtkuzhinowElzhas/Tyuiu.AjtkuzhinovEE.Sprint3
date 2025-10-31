using Tyuiu.AjtkuzhinovEE.Sprint3.Task6.V8.Lib;
namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 18;
            int stopValue = 28;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 292;
            Assert.AreEqual(wait, res);

        }
    }
}
