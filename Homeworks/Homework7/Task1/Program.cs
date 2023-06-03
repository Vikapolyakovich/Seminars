//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] Create2DRandomArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue), 1);
        }
    }
    return array;
}

void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " "); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value");
int maxValue = Convert.ToInt32(Console.ReadLine());

Print2DArray(Create2DRandomArray(rows, columns, minValue, maxValue));