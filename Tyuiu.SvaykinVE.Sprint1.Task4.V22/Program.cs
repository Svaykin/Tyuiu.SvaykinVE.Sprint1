using Tyuiu.SvaykinVE.Sprint1.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Свайкин В. Е. | AСОиУб-25-1";
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                  *");
        Console.WriteLine("* Задание #4                                                                        *");
        Console.WriteLine("* Вариант #22                                                                       *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | AСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,           *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране                           *");
        Console.WriteLine("*                                                                                   *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");

        double x;
        Console.WriteLine("Введите переменную x = ");
        x = Convert.ToDouble(Console.ReadLine());

        double y;
        Console.WriteLine("Введите перменную y = ");
        y= Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}