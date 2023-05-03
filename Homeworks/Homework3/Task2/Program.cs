Console.WriteLine("Введите координату первой точки: ");
int x1 = Convert.ToInt16(Console.ReadLine());
int y1 = Convert.ToInt16(Console.ReadLine());
int z1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите координату второй точки: ");
int x2 = Convert.ToInt16(Console.ReadLine());
int y2 = Convert.ToInt16(Console.ReadLine());
int z2 = Convert.ToInt16(Console.ReadLine());

double DistancePoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return result;
}

double result = Math.Round(DistancePoints(x1, y1, z1, x2, y2, z2),2);
Console.WriteLine($"Расстояние между точками {result}");