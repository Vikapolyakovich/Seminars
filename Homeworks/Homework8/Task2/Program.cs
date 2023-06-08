// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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


int MinSumInRow(int[,] array)
{
    int minsumm = 0;
    int row = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (minsumm != 0)
        {
            if (sum < minsumm)
            {
                minsumm = sum;
                row = i;
            }
        }
        else 
        {
            minsumm = sum;
        }
        sum = 0;
    }
    return row+1;
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
    
Console.WriteLine($"Строка с наименьшей суммой элементов: {MinSumInRow(myArray)}"); 
