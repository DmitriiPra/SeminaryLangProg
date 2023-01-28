// Принимает на вход координаты двух точек и
// находит расстояние между ними в двухмерном пространстве
// Например:    A (3; 6), B (2, 1) -> 5,09
//              A (7; -5), B (1, -1) -> 7,21

Console.WriteLine("Введите координаты 2х точек А и В:");
Console.Write("Значение координаты Х точки А = ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Y точки А = ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Х точки B = ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Y точки B = ");
int bY = Convert.ToInt32(Console.ReadLine());

double Hypotenuse(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
}

double result = Hypotenuse(aX, aY, bX, bY);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и В = {resultRound}");
