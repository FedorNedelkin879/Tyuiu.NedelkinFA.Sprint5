using Tyuiu.NedelkinFA.Sprint5.Task7.V15.Lib;

DataService ds = new DataService();
string path = Path.Combine(Path.GetTempPath(), "InPutFileTask7V15.txt");
string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V15.txt");
Console.WriteLine("file tut: " + path);
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine("resultat: " + pathSaveFile);
Console.ReadKey();
