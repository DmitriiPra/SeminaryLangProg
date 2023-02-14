// Найти точку пересечения прямых, заданных уравнениями
// y = k1 * x + b1 и y = k2 * x + b2
// значения k1, b1, k2, b2 задаются пользователем
// 

Console.WriteLine("Введите значение k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

int coordX = (b2 - b1) / (k1 - k2);
int coordY = k1 * coordX + b1;

Console.WriteLine($"{coordX} , {coordY}");

// int[] IntersectionPoint(int a1, int c1, int a2, int c2)
// {
//     int[] coordinats = new int[2];
//     a1 * x + c1 = a2 * x + c2 -> 
//     a1x - a2x = c2 - c1
//     x(a1-a2) = c2 - c1
//     x = (c2 - c1)/(a1-a2)
//     coordinats[0] = (c2 - c1) / (a1 - a2);
//     coordinats[1] = a1 * coordinats[0] + c1; // coordinats[1] = a1 * ((c2 - c1) / (a1 - a2)) + c1;
//     return coordinats;
// }
// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     // Console.Write($"{arr[arr.Length - 1]}");
// }

// int intersectionPoint = IntersectionPoint(k1, b1, k2, b2);
// PrintArray(coordinats);


// int IntersectionPointY(int x1, int a1, int c1)
// {
//     int y = default;
//     //a1 * x + c1 = a2 * x + c2
//     return y = a1 * x1 + c1;
// }


// расчитываем значение Х из уравнения  k1 * x + b1 = k2 * x + b2
// расчитываем значение У по полученному значению Х  y = k1 * x + b1
//5x + 2 = 9x +4
// 4x = 2
// x = 0,5
// y = 2,5 + 2
// y= 4,5 + 4