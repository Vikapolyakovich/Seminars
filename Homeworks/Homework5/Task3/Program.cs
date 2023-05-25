double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue+1);
    }
    return newArray;
}



void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    return max-min;
}

Console.WriteLine("Input array size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input minimal value of element");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximal value of element");
int maxValue = Convert.ToInt32(Console.ReadLine());


double[] newArray = CreateRandomArray(size, minValue, maxValue);
PrintArray(newArray);
double result = Difference(newArray);
Console.WriteLine($"Разница максимального и минимального числа {result}");