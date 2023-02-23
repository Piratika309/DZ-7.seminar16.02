// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine() ?? "0");

int [,] array = new int [n,m];
Random random = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = random.Next(0,10);
        Console.Write($"{array[i,j]}\t");
    }
     Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);


void OrderArrayLines(int[,] array)
{
  int row_count = array.GetLength(0);
  int column_count = array.GetLength(1);
  
  for (int i = 0; i < row_count; i++)
  {
    for (int j = 0; j < column_count; j++)
    {
      for (int k = 0; k < column_count-1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  for (int i = 0; i < row_count; i++)
  {
    for (int j = 0; j < column_count; j++)
    {
        Console.Write($"{array[i,j]}\t");
    }
    Console.WriteLine();
  }
}
//Console.WriteLine($"\nОтсортированный массив: ");
//OrderArrayLines(array);

//Console.WriteLine($"{array}");



//Console.WriteLine($"\nОтсортированный массив: ");
//OrderArrayLines(array);
//print temp;

    //array[j,k] = arraystr;
    //Console.Write(array[j, k] + " ");
    //count++;
    


//for (int i = 0; i < array.GetLength(0); i++)
//{
  //  for (int j = 0; j < array.GetLength(1); j++)
    //{
      //  sum[j] += array[i,j];
    //}
//}

//for (int j = 0; j < array.GetLength(0); j++)
//{
  //   Console.WriteLine($"{s++}  среднее арифметическое данного столбца равно: "  + (sum[j]/n) + " ");
//}
 //Console.WriteLine();
