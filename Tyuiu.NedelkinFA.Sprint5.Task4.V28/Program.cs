using Tyuiu.NedelkinFA.Sprint5.Task4.V28.Lib;

DataService ds = new DataService();
string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask4.txt";
Console.WriteLine("дан тут: " + path);
double result = ds.LoadFromDataFile(path);
Console.WriteLine("фил тут: " + result);
Console.ReadKey();
