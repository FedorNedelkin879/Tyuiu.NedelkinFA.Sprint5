﻿using Tyuiu.NedelkinFA.Sprint5.Task1.V17.Lib;
int startVaule = 7;
int stopVaule = 8;
DataService ds = new DataService();
Console.WriteLine("startVaule = " + startVaule);
Console.WriteLine("stopVaule = " + stopVaule);
string res = ds.SaveToFileTextData(startVaule, stopVaule);
Console.WriteLine("file: " + res);
Console.WriteLine("sozdan!");
Console.ReadKey();