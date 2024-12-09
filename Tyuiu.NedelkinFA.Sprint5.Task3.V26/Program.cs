using Tyuiu.NedelkinFA.Sprint5.Task3.V26.Lib;

int x = 2;
DataService ds = new DataService();
string filePath = ds.SaveToFileTextData(x);
Console.WriteLine("Файл создан: " + filePath);
Console.ReadKey();