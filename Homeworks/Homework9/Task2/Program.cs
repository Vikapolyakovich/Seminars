// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.



int ShowNumbers(int m, int n)
{
    if (n > m)
    {
        return m + ShowNumbers(m+1, n);
    }
    else return m;
}

Console.WriteLine(ShowNumbers(4, 8));
