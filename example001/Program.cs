// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int [,] array = new int [n,m];
int [] sum = new int [m];
int s = 1;
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = random.Next(0,20);
        Console.Write($"{array[i,j]}\t");
    }
     Console.WriteLine();
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum[j] += array[i,j];
    }
}

for (int j = 0; j < array.GetLength(0); j++)
{
     Console.WriteLine($"{s++}  среднее арифметическое данного столбца равно: "  + (sum[j]/n) + " ");
}
 Console.WriteLine();