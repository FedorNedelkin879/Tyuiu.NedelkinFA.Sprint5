using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public double CalculateFunction(int x)
        {
            return 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
        }

        public string SaveToFileTextData(int x)
        {
            double result = CalculateFunction(x);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            string formattedResult = result.ToString("F3").Replace('.', ',');
            File.WriteAllText(path, $"\"{formattedResult}\"");
            return path;
        }
    }
}