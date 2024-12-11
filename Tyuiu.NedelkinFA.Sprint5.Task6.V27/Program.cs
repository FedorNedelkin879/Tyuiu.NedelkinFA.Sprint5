using Tyuiu.NedelkinFA.Sprint5.Task6.V27.Lib;

DataService ds = new DataService();
string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask6.txt";
Console.WriteLine("fil tut: " + path);
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();