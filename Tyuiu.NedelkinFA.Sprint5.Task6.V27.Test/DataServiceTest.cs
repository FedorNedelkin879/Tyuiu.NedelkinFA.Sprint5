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
            string path = $@"C:\Users\Федя\source\repos\Tyuiu.NedelkinFA.Sprint5\Tyuiu.NedelkinFA.Sprint5.Task6.V27\bin\Debug\InPutFileTask6V27.txt";
            var res = ds.LoadFromDataFile(path);
            int wait = 10;
            Assert.AreEqual(wait, res);
        }
        [TestMethod] 
        public void CheckedExistsFile()
        {
            string path = $@"C:\Users\Федя\source\repos\Tyuiu.NedelkinFA.Sprint5\Tyuiu.NedelkinFA.Sprint5.Task6.V27\bin\Debug\InPutFileTask6V27.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}