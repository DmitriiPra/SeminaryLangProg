/*
Задайте значение N. 
Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NaturalNumber(int a)
{
    if (a>1) Console.Write($"{a}, ");
    else Console.Write($"{a}");
    if (a == 1) return;
    else NaturalNumber(a - 1);
}

Console.Write("Задайте значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    Console.Write($" N = {n} -> ");
    NaturalNumber(n);
    Console.WriteLine();
}
else Console.WriteLine("Введено некорректное значение N");