int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber(int number)
{
    if (number > 99999 || number <= 9999  )
    {
        Console.WriteLine("Число не пятизначное. Введите пятизначное число");
        return false;
    }
    return true;
}

void Palindrom(int number)
{
    int num1 = number/10000;
    int num2 = number/1000%10;
    int num4 = number%100/10;
    if (number%10 == num1)
    {
        if (num2 == num4)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else 
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}

int number = Prompt("Введите число: ");
if (ValidateNumber(number))
{
    Palindrom(number);
}