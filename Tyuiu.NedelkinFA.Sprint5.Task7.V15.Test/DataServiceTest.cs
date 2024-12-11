using Tyuiu.NedelkinFA.Sprint5.Task7.V15.Lib;

namespace Tyuiu.NedelkinFA.Sprint5.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidWordDeletion()
        {
            string inputPath = Path.Combine(Path.GetTempPath(), "InPutFileTask7V15.txt");
            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V15.txt");
            File.WriteAllText(inputPath, "This is a test string with to delete.");
            DataService ds = new DataService();
            ds.LoadDataAndSave(inputPath);
            string result = File.ReadAllText(outputPath).Trim();
            Assert.AreEqual("This test string with delete.", result);
        }
    }
}
