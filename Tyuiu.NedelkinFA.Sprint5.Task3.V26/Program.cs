using Tyuiu.NedelkinFA.Sprint5.Task3.V26.Lib;

int x = 2;
DataService ds = new DataService();
double result = ds.CalculateF(x);
Console.WriteLine("F(" + x + ") = " + Math.Round(result, 3));
string filePath = ds.SaveToFileTextData(result);
Console.WriteLine("Файл создан: " + filePath);
Console.ReadKey();