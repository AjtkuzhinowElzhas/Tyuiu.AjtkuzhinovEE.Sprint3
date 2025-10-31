using Tyuiu.AjtkuzhinovEE.Sprint3.Task6.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        int startValue = 18;
        int stopValue = 28;

        Console.WriteLine("Старт шага:" + startValue);
        Console.WriteLine("Конец шага:" + stopValue);



        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Результат:                                                                   *");
        Console.WriteLine("********************************************************************************");


        Console.WriteLine("Сумма  = " + ds.GetSumTheDivisors(startValue, stopValue));

        Console.ReadKey();
    }
}