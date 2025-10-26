using System.Security.Cryptography;
using 
namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task0.V3.Lib
{
    public class DataService : 
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            DataService ds = new DataService();

            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries += Math.Sin(i) * Math.Pow(0.5, 2);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
