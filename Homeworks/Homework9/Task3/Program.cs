// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


int Akkermanfun(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkermanfun(m - 1, 1);
    }
    else
    {
        return (Akkermanfun(m - 1, Akkermanfun(m, n - 1)));
    }
}



Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(Akkermanfun(m, n)); 