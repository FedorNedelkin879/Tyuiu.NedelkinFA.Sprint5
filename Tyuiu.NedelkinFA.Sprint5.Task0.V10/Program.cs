using Tyuiu.NedelkinFA.Sprint5.Task0.V10;
using Tyuiu.NedelkinFA.Sprint5.Task0.V10.Lib;

int x = 2;
DataService ds = new DataService();
double result = ds.CalculateFunction(x);
Console.WriteLine("F(" + x + ") = " + result.ToString("F3").Replace('.', ','));
string filePath = ds.SaveToFileTextData(x);
Console.WriteLine("file: " + filePath);
Console.WriteLine("создан!");
Console.ReadKey();