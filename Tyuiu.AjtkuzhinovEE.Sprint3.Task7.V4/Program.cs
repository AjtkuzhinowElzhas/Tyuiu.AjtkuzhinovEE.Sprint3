
using Tyuiu.AjtkuzhinovEE.Sprint3.Task7.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Айткужинов Е. Е. | РППб-25-1 ";
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* Спринт #3                                                                    *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проетов по спринту                       *");
        Console.WriteLine("* Задание #7                                                                   *");
        Console.WriteLine("* Вариант #4                                                                   *");
        Console.WriteLine("* Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1                            *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                     *");
        Console.WriteLine("* Написать программу, которая выводит таблицу значений функции на диапозоне    *");
        Console.WriteLine("* [-5;5] c шагом 1                                                             *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                             *");
        Console.WriteLine("********************************************************************************");


        int startValue = -5;
        int stopValue = 5;

        Console.WriteLine("Старт шага = " + startValue);
        Console.WriteLine("Конец шага = " + stopValue);


        int len = ds.GetMassFunction(startValue, stopValue).Length;

        double[] valueArray = new double[len];
        valueArray = new double[len];

        valueArray = ds.GetMassFunction(startValue, stopValue);

        Console.WriteLine("********************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("+----------+-----------+");
        Console.WriteLine("|     X    |    f(x)   |");
        Console.WriteLine("+----------+-----------+");
        for (int i = 0; i <= len-1; i++)
        {
            Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, valueArray[i]);
            startValue++;
        }
        Console.WriteLine("+----------+----------+");
        Console.ReadKey();
    }
}