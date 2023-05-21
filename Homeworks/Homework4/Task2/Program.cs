//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


void DigitSumm(int number)
{
    int result = 0;
    int num = number;
    for (int i = 0; number > 0; i++)
    {
        int digit = number%10;
        result += digit;
        number/=10;
    }
    Console.WriteLine($"{num} -> {result}");
}

Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

DigitSumm(number);