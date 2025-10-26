using Tyuiu.AjtkuzhinovEE.Sprint3.Task1.V28.Lib;

internal class Program  
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу используя цикл while,которая вычисляет сумму ряда по  *");
        Console.WriteLine("*формуле , при а = 0.5                                                    *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double value = 0.5;
        int startValue = 1; // старт
        int stopValue = 18; // конец

        Console.WriteLine("Переменная а = " + value);
        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();



        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(value, startValue, stopValue));
        Console.ReadKey();
    }
}