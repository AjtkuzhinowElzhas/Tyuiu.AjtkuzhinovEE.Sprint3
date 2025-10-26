using Tyuiu.AjtkuzhinovEE.Sprint3.Task0.V3.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint3.Task0.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();// создали объект DataService

            int startValue = 1; // старт
            int stopValue = 10; // конец

            double res = ds.GetSumSeries(startValue, stopValue); //то что считает в библиотеке
            double wait = 0.353; //Ожидаемы результат - Не забыть про округление до 3-х знаков после запятой
            Assert.AreEqual(wait, res); // то что ожидаем и с помощью чего считаем

        }
    }
}
