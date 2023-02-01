/* Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.WriteLine("Введите 3D координаты 2х точек А и В:");
Console.Write("Значение координаты Х точки А = ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Y точки А = ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Z точки А = ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Х точки B = ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Y точки B = ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение координаты Z точки B = ");
int bZ = Convert.ToInt32(Console.ReadLine());

double Hypotenuse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double hypoXY = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return Math.Sqrt(Math.Pow((hypoXY), 2) + Math.Pow((z1 - z2), 2));
}

double result = Hypotenuse(aX, aY, aZ, bX, bY, bZ);
double resultRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и В = {resultRound}");