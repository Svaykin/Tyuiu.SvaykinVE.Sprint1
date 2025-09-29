using Microsoft.ApplicationInsights.DataContracts;
using Tyuiu.SvaykinVE.Sprint1.Task2.V6.Lib;

namespace Tyuiu.SvaykinVE.Sprint1.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression ()
        {
            DataService ds = new DataService();
            int x = 9999;
            var res = ds.ConvertMToKm(x);
            Assert.AreEqual(9.999, res);
        }
    }
}
