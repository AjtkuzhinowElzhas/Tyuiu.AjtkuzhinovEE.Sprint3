using Tyuiu.AjtkuzhinovEE.Sprint3.Task3.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #3 | Выполнил: Айткужинов Елжас Есилбаевич | РППб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема:  Оператор цикла foreach                                           *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил:     Айткужинов Елжас | ИСПб-24-1                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
        Console.WriteLine("*  находящихся на соседних позициях в строке: \"tbtbbb dsfbg bbg\"        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Исходные данные:                                                        *");
        Console.WriteLine("***************************************************************************");

        string value = "tbtbbb dsfbg bbg";
        char item = 'b';
        Console.WriteLine("Исходная строка = " + value);
        Console.WriteLine("Искомый символ " + item);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                              *");
        Console.WriteLine("***************************************************************************");

        int res = ds.GetMaxCharCount(value, item);
        Console.WriteLine(res);
        Console.ReadLine();
    }
}