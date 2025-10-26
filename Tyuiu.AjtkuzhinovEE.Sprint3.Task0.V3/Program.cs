using Tyuiu.AjtkuzhinovEE.Sprint3.Task0.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #3 | Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1";
        //Длинна строки 75 символов
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Оператор цикла for                                                      *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1\"                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");

        Console.WriteLine("*Написать программу используя цикл for, которая вычисляет сумму ряда по   *");
        Console.WriteLine("*формуле                                                                  *");

        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 1; // старт
        int stopValue = 10; // конец


        Console.WriteLine("Старт шага = " + startValue                                                 );
        Console.WriteLine("Конец шага = " + stopValue                                                  );

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();

        

        Console.WriteLine("Сумма ряда = " + ds.GetSumSeries(startValue, stopValue));
        Console.ReadKey();
    }
}