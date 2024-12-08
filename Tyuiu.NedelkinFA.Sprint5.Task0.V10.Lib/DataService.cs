using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string CalculateFunction(int x)
        {
            double result = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;
            return Math.Round(result, 3).ToString("F3").Replace('.', ','); 
        }

        public string SaveToFileTextData(int x)
        {
            string formattedResult = CalculateFunction(x);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, $"\"{formattedResult}\"");
            return path;
        }
    }
}