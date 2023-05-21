// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] CreateRandomArray(int minValue, int maxValue)
{   
    int size = 8;
    int[] newArray = new int[size]; 
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Input minimal value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of element");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[] MyArray = CreateRandomArray(minValue, maxValue);
PrintArray(MyArray);
