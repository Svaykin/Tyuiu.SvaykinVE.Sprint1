using Tyuiu.SvaykinVE.Sprint1.Task6.V3.Lib;
namespace Tyuiu.SvaykinVE.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string x = "здарова надоел лол кама";
            string res = ds.LastLetterWord(x);
            Assert.AreEqual("алла", res);
        }
    }
}
