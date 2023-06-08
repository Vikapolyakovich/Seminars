// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



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

int[] SortArrayDescending(int[] array)
{
    
    for (int i = 0; i < array.Length-1; i++)
    {
        for (int j = i + 1; j < array.Length-(1+i); i++)
        {
            int tempnum = 0;
            if (array[j] > array[j+1])
            {
                tempnum = array[j+1];
                array[j+1] = array[j];
                array[j] = tempnum;
            }
        }
    }
    return array;
}

int[,] Sort2DArrayDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                int tempnum = 0;
                if (array[k, j] > array[k, j+1])
                {
                    tempnum = array[k, j+1];
                    array[k, j+1] = array[k, j];
                    array[k, j] = tempnum;
                }
            }
        }
    }
    return array;
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

int[,] newSort2DArray = Sort2DArrayDescending(myArray);
Print2DArray(newSort2DArray);