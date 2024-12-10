using Tyuiu.NedelkinFA.Sprint5.Task4.V28.Lib;

DataService ds = new DataService();
string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
Console.WriteLine("dannie tut: " + path);
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
