int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++ )
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

void EvenNumbers(int[] array)
{
    Console.Write("Четные числа: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write($"{array[i]} ");
        }
    }
}


int[] newArray = FillArray(3);
PrintArray(newArray);
EvenNumbers(newArray);
