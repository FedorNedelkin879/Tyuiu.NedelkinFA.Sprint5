﻿using Tyuiu.NedelkinFA.Sprint5.Task5.V14.Lib;

DataService ds = new DataService();
string path = $@"C:\Users\Федя\source\repos\Tyuiu.NedelkinFA.Sprint5\Tyuiu.NedelkinFA.Sprint5.Task5.V14\bin\Debug\DataSprint5\InPutDataFileTask5V14.txt";
Console.WriteLine("dan tut: " + path);
double res = ds.LoadFromDataFile(path);
Console.WriteLine("fac:" + res);
Console.ReadKey();
