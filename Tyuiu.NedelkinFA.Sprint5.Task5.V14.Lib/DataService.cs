using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task5.V14.Lib
{
    public class DataService : ISprint5Task5V14
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    res = res + Convert.ToDouble(line);
                }
            }
            return res;
        }
    }
}
