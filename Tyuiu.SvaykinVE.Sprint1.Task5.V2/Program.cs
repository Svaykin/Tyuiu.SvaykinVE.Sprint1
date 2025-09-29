using Tyuiu.SvaykinVE.Sprint1.Task5.V2.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Свайкин В. Е. | AСОиУб-25-1";
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                  *");
        Console.WriteLine("* Задание #5                                                                        *");
        Console.WriteLine("* Вариант #2                                                                        *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | AСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                              *");
        Console.WriteLine("* Дано значение температуры в градусах Фаренгейта.                                  *");
        Console.WriteLine("* Определить значение этой же температуры в градусах Цельсия.                       *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");

        double x;
        Console.WriteLine("Введите температуру в градусах Фаренгейта = ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine(ds.FahrenheitToСelsius(x));
        Console.ReadLine();
    }
}