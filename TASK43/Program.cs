// Найти точку пересечения прямых, заданных уравнениями
// y = k1 * x + b1 и y = k2 * x + b2
// значения k1, b1, k2, b2 задаются пользователем
// 
//     k01 * x + b01 = k02 * x + b02 -> 
//     k01x - k02x = b02 - b01
//     x(k01-k02) = b02 - b01
//     x = (b02 - b01)/(k01-k02)


Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

void CrossCoordinates(double k01, double b01, double k02, double b02)
{
    double coordX = (b02 - b01) / (k01 - k02);
    double coordY = k01 * coordX + b01;

    Console.WriteLine($"координаты точки пересечения прямых: x = {coordX} , y = {coordY}");
}
CrossCoordinates(k1, b1, k2, b2);

/* решение через массив
double[] IntersectionPoint(double k01, double b01, double k02, double b02)
{
    double[] coordinats = new double[2];

    coordinats[0] = (b02 - b01) / (k01 - k02);
    coordinats[1] = k01 * ((b02 - b01) / (k01 - k02)) + b01;
    return coordinats;
}
// void PrintArray(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     // Console.Write($"{arr[arr.Length - 1]}");
// }

double intersectionPoint = IntersectionPoint(k1, b1, k2, b2);
*/