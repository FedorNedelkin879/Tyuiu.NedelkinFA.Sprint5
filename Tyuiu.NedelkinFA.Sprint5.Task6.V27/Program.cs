using Tyuiu.NedelkinFA.Sprint5.Task6.V27.Lib;

DataService ds = new DataService();
string path = Path.Combine(Path.GetTempPath(), "InPutFileTask6V27.txt");
Console.WriteLine("fil tut " + path);
double res = ds.LoadFromDataFile(path);
Console.WriteLine("kolich" + res);
Console.ReadKey();
