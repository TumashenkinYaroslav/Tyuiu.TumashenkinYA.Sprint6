using Tyuiu.TumashenkinYA.Sprint6.Task6.V7.Lib;
namespace Tyuiu.TumashenkinYA.Sprint6.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestCollectText()
        {
            DataService ds = new DataService();
            string path = $@"C:\DataSprint6\InPutDataFileTask6V7.txt";
            string wait = "cHshl fGf bBYQQ pmYGtO xakZKciG";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
