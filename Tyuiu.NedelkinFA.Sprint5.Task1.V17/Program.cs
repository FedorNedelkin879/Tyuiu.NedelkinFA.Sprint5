using Tyuiu.NedelkinFA.Sprint5.Task1.V17.Lib;

int startValue = -5;
int stopValue = 5;
DataService ds = new DataService();
Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);
string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("file: " + res);
Console.WriteLine("создан!");
Console.ReadKey();