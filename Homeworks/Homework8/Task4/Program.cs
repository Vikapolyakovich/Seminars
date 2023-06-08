// Задача. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] Create3DRandomArray(int rows, int columns, int deep)
{
    int[,,] array = new int[rows, columns, deep];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
          for (int k = 0; k < deep; k++)
          {
            array[i, j , k] = new Random().Next(10, 100);
            for (int l = 0; l < rows; l++)
            {
              for (int m = 0; m < columns; m++)
              {
                for (int n = 0; n < deep; n++)
                {
                  if (array[l, m, n] == array[j, k, l])
                  {
                    array[i, j, k] = new Random().Next(10, 100);
                  }
                }
              }
            }
          }
        }
    }
    return array;
}


void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          for (int k = 0; k < array.GetLength(2); k++)
          {
            Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
          }
          Console.WriteLine();
        }
    }
    Console.WriteLine();
}


    

Console.WriteLine("Input number of rows ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of deep ");
int deep = Convert.ToInt32(Console.ReadLine());



int[,,] myarray = Create3DRandomArray(rows, columns, deep); 
Print3DArray(myarray);
