using Tyuiu.NedelkinFA.Sprint5.Task2.V22.Lib;

int[,] mtrx = new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Введите элемент [{i},{j}]: ");
        mtrx[i, j] = int.Parse(Console.ReadLine());
    }
}
int rows = mtrx.GetUpperBound(0) + 1;
int columns = mtrx.Length / rows;
DataService ds = new DataService();
Console.WriteLine("massive:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]}\t");
    }
    Console.WriteLine();
}
string res = ds.SaveToFileTextData(mtrx);
Console.WriteLine("file: " + res);
Console.WriteLine("создан!");
Console.ReadKey();