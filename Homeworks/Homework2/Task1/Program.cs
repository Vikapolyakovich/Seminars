int SecondDigit (int num)
{
    int secondnum = num/10%10;
    return secondnum;
}


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Второе число: -> {SecondDigit(num)}");
