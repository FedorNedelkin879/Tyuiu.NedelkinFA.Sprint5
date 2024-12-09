using Tyuiu.NedelkinFA.Sprint5.Task3.V26.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Федя\source\repos\Tyuiu.NedelkinFA.Sprint5\Tyuiu.NedelkinFA.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool expected = true;
            Assert.AreEqual(expected, fileExists);
        }
    }
}