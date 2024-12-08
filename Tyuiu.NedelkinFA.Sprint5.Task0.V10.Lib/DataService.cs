using System.IO;

namespace Tyuiu.NedelkinFA.Sprint5.Task0.V10.Lib
{
    public class DataService
    {
        public double CalculateFunction(int x)
        {
            return 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
        }

        public string SaveToFileTextData(double result)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            result = Math.Round(result, 3);
            File.WriteAllText(path, Convert.ToString(result));
            return path;
        }
    }
}