using Tyuiu.AjtkuzhinovEE.Sprint3.Task7.V4.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = -2.15;//-5
            valueWaitArray[1] = -2.57;//-4
            valueWaitArray[2] = -3.00;//-3
            valueWaitArray[3] = -3.83;//-2
            valueWaitArray[4] = -11.70;//-1
            valueWaitArray[5] = 3.00;//0
            valueWaitArray[6] = 2.19;//1
            valueWaitArray[7] = 3.31;//2
            valueWaitArray[8] = 2.97;//3
            valueWaitArray[9] = 1.18;//4
            valueWaitArray[10] = 0.03;//5

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
