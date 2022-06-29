// Напишите программу, которая найдет точку пересечения двух прямых,
// заданных уравнениями:
// y = k1 * x + b1,
// y = k2 * x + b2,
// значения b1, k1, b2, k2 задаются пользователем.

// Например b1=2, k1=5, b2=4, k2=9 Ответ (-0,5; -0;5)

void IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k2 * x + b2;

    Console.WriteLine($"координаты точки пересечения: x = {x}; y = {y}");
}


Console.WriteLine($"Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);