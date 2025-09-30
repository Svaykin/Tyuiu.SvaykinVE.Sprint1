using Tyuiu.SvaykinVE.Sprint1.Task7.V25.Lib;

namespace Tyuiu.SvaykinVE.Sprint1.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(20.231, res);
        }
    }
}
