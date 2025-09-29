using Tyuiu.SvaykinVE.Sprint1.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Свайкин В. Е. | AСОиУб-25-1";
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                         *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                                  *");
        Console.WriteLine("* Задание #3                                                                        *");
        Console.WriteLine("* Вариант #10                                                                        *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | AСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,           *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране                        *");
        Console.WriteLine("*                                                                                   *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");

        double x = 23.6;
        Console.WriteLine("Введённое дробное число = "+x);


        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine(""+ds.NumberToMoney(x));
        Console.ReadLine();
    }
}