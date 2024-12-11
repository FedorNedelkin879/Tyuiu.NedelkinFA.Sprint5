using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.NedelkinFA.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', '\t', '\n', '\r');
                    foreach (string word in words)
                    {
                        if (word.Length == 3 && int.TryParse(word, out _))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
