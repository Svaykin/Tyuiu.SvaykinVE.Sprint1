using Tyuiu.SvaykinVE.Sprint1.Task6.V3.Lib;
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
        Console.WriteLine("* Вариант #3                                                                        *");
        Console.WriteLine("* Выполнил: Свайкин Владислав Евгеньевич | AСОиУб-25-1                              *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                          *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                                    *");
        Console.WriteLine("* Напечатать строку, составленную из последних литер всех слов.                     *");
        Console.WriteLine("*                                                                                   *");
        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
        Console.WriteLine("*************************************************************************************");

        string x;
        Console.WriteLine("Напечатайте строку ");
        x = Console.ReadLine();


        Console.WriteLine("*************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                                         *");
        Console.WriteLine("*************************************************************************************");

        Console.WriteLine(ds.LastLetterWord(x));
        Console.ReadLine();
    }
}