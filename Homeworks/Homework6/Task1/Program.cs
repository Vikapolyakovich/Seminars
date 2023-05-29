//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



int[]InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Input {i+1} element");
        int element = Convert.ToInt32(Console.ReadLine());
        array[i] = element;
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


int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}



Console.WriteLine("Input size array ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(length);
PrintArray(array);
Console.WriteLine($" Кол-во элементов больше 0: {CountPositiveNumbers(array)}");