using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            double value = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            value = Math.Round(value, 3);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(value));
            }
            return path;
        }
    }
}