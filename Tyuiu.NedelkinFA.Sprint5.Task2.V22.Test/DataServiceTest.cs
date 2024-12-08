using Tyuiu.NedelkinFA.Sprint5.Task2.V22.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool expected = true;
            Assert.AreEqual(expected, fileExists);
        }
    }
}