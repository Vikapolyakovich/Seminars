void CubeTable(int number)
{
    int count = 1;
    while (number >= count)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
        count++;
    }
}

Console.WriteLine($"Введите число: ");
int N = Convert.ToInt16(Console.ReadLine());
CubeTable(N);