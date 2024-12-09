using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public double CalculateF(int x)
        {
            return 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
        }

        public string SaveToFileTextData(double value)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");
            value = Math.Round(value, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(value));
            }
            return path;
        }
    }
}