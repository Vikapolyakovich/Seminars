// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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


void ValueElement(int[,] array, int positionRow, int positionColumn)
{
    if (positionRow < array.GetLength(0) && positionColumn < array.GetLength(1))
    {
        Console.WriteLine($"Значение элемента на позиции {positionRow} {positionColumn}: {array[positionRow, positionColumn]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
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

Console.WriteLine("Input PositionRow");
int positionRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input PositionColumn");
int positionColumn = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);

ValueElement(myArray, positionRow, positionColumn);