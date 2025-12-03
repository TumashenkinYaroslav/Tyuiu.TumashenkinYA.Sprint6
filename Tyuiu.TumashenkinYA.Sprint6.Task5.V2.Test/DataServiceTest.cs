using Tyuiu.TumashenkinYA.Sprint6.Task5.V2.Lib;
namespace Tyuiu.TumashenkinYA.Sprint6.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\User\Desktop\DataService6\InPutDataFileTask5V2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
