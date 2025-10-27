using Tyuiu.AjtkuzhinovEE.Sprint3.Task2.V29.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;

            DataService ds = new DataService();

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -0.186;
            Assert.AreEqual(wait, res);


        }
    }
}
