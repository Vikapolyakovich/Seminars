//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    if (n > 0)
    {
        Console.Write(n + " ");
        ShowNumbers(n - 1);
    }
}

ShowNumbers(5);
