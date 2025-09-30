using Tyuiu.SvaykinVE.Sprint1.Task7.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Свайкин В. Е. | AСОиУб-25-1";
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                  *");
        Console.WriteLine("* Задание #7                                                                        *");
        Console.WriteLine("* Вариант #25                                                                       *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | AСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                    *");
        Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                             *");
        Console.WriteLine("*                                                                                   *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("*        2          3         2                                                     *");
        Console.WriteLine("*    x  y + 6 + cosx + xy - 2x                                                      *");
        Console.WriteLine("* z=e - -----------------------                                                     *");
        Console.WriteLine("*            4                                                                      *");
        Console.WriteLine("*       sin(x + 13) + 9y - 2                                                        *");
        Console.WriteLine("*************************************************************************************");


        double x;
        Console.WriteLine("Введите переменную x = ");
        x = Convert.ToDouble(Console.ReadLine());

        double y;
        Console.WriteLine("Введите перменную y = ");
        y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadLine();
    }
}