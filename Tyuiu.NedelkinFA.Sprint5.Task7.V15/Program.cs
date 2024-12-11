using Tyuiu.NedelkinFA.Sprint5.Task7.V15.Lib;

DataService ds  = new DataService();
string path = $@"{Directory.GetCurrentDirectory()}\InPutFileTask7V15.txt";
string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V15.txt";
Console.WriteLine("file tut: " + path);
Console.WriteLine("resultat v :");
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine(pathSaveFile);
Console.ReadKey();