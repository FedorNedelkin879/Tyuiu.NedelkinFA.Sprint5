using Tyuiu.NedelkinFA.Sprint5.Task7.V15.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\Федя\source\repos\Tyuiu.NedelkinFA.Sprint5\Tyuiu.NedelkinFA.Sprint5.Task7.V15\bin\Debug\InPutDataFileTask7V15.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}