using Tyuiu.NedelkinFA.Sprint5.Task1.V17.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Федя\source\repos\Tyuiu.NedelkinFA.Sprint5\Tyuiu.NedelkinFA.Sprint5.Task1.V17\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}