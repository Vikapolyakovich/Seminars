// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return array;
}


void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] MultiMatrix(int[,] firstarray,  int[,] secondarray)
{
  int[,] multiarray = new int[firstarray.GetLength(0), firstarray.GetLength(0)];
  if (firstarray.GetLength(1) == secondarray.GetLength(0))
  {   
    for (int i = 0; i < multiarray.GetLength(0); i++)
    {
      for (int j = 0; j < multiarray.GetLength(1); j++)
      {
        int sum = 0;
        for (int k = 0; k < firstarray.GetLength(1); k++)
        {
            sum += firstarray[i, k] * secondarray[k, j];
        }
        multiarray[i, j] = sum;
      }
    }
  }
  return multiarray;
}

    
Console.WriteLine("Input minimal value");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of rows of first array");
int firstrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns of first array");
int firstcolumns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of rows of second array");
int secondrows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns of second array");
int secondcolumns = Convert.ToInt32(Console.ReadLine());



int[,] firstarray = Create2DRandomArray(firstrows, firstcolumns, minValue, maxValue); 
int[,] secondarray = Create2DRandomArray(secondrows, secondcolumns, minValue, maxValue); 
Print2DArray(firstarray);
Print2DArray(secondarray);
int[,] resultarray = MultiMatrix(firstarray, secondarray);
Console.WriteLine("Результат перемножения матриц");
Print2DArray(resultarray);