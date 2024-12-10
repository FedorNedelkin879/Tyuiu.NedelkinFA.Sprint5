using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task4.V28.Lib
{
    public class DataService : ISprint5Task4V28
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double res = Math.Round(Math.Pow(Convert.ToDouble(strX), 2), 3);
            return res;
        }
    }
}
