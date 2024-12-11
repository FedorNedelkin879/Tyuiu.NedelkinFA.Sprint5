using Tyuiu.NedelkinFA.Sprint5.Task6.V27.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task6.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask6V27.txt");
            File.WriteAllText(path, "123 abc 456 789 12 345");
            var res = ds.LoadFromDataFile(path);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask6V27.txt");
            File.WriteAllText(path, "vremenno");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
