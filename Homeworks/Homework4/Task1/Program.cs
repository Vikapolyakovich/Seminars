//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


void NumberExponentiation(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result*number1;
    }
    Console.WriteLine($"{number1}, {number2} -> {result}");
}

Console.WriteLine("Input first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int number2 = Convert.ToInt32(Console.ReadLine());

NumberExponentiation(number1, number2);