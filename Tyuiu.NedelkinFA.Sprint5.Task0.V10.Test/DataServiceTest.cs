using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.NedelkinFA.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool expected = true;
            Assert.AreEqual(expected, fileExists);
        }
    }
}