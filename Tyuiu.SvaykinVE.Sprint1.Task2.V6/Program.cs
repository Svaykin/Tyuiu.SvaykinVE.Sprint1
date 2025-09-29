using Tyuiu.SvaykinVE.Sprint1.Task2.V6.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Свайкин В. Е. | AСОиУб-25-1";
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                  *");
        Console.WriteLine("* Задание #2                                                                        *");
        Console.WriteLine("* Вариант #6                                                                        *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | AСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,           *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране                        *");
        Console.WriteLine("*                                                                                   *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");

        int x;
        Console.WriteLine("Расстояние в метрах = ");
        x = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine("Расстояние в километрах = "+ds.ConvertMToKm(x));
        Console.ReadLine();
    }
}