using Tyuiu.NedelkinFA.Sprint5.Task4.V28.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutFileTask4.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool expected = true;
            Assert.AreEqual(expected, fileExists);
        }
    }
}