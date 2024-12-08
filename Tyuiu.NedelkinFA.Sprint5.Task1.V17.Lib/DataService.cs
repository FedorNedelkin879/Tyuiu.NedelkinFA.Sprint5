﻿using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.NedelkinFA.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            if (fileinfo.Exists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(" x\t\tF(x)");
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = Math.Sin(x) + 1;
                    if (denominator == 0)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = 2 * x - 4 + (2 * x - 1) / denominator;
                    }
                    strY = Math.Round(y, 2).ToString();
                    writer.WriteLine($"{x}\t\t{strY}");
                }
            }
            return path;
        }
    }
}