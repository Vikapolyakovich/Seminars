//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void AverageColumn(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j] += array[i, j]; 
        }
    }
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        newArray[i] /= array.GetLength(0);
    }
    Console.Write($"Среднее арифметическое каждого столбца: ");
    PrintArray(newArray);
}

Console.WriteLine("Input number of rows");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of columns");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input minimal value");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input maximal value");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);

AverageColumn(myArray);