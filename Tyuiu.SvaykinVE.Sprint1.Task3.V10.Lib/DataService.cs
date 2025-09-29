using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SvaykinVE.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            return number+" руб. - это "+(int)number + " руб. " + (int)((number - (int)number) * 100)+" коп.";
        }
    }
}
