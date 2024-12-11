using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NedelkinFA.Sprint5.Task7.V15.Lib
{
    public class DataService : ISprint5Task7V15
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V15.txt");
            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }
            using (StreamReader reader = new StreamReader(path))
            {
                using (StreamWriter writer = new StreamWriter(pathSaveFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(' ', '\t', '\n', '\r');
                        string resultLine = string.Join(" ", words.Where(word => word.Length != 2));
                        writer.WriteLine(resultLine);
                    }
                }
            }
            return pathSaveFile;
        }
    }
}
