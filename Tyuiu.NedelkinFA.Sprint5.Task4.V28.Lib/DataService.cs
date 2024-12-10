using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX.Replace(',', '.'));
            double result = Math.Round((3 * x * x * x) / Math.Sin(x), 3);
            return result;
        }
    }
}
