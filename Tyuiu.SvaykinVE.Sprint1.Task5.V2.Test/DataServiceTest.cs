using System.Xml.XPath;
using Tyuiu.SvaykinVE.Sprint1.Task5.V2.Lib;

namespace Tyuiu.SvaykinVE.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 41;
            var res = ds.FahrenheitToСelsius(x);
            Assert.AreEqual(5, res);
        }
    }
}
