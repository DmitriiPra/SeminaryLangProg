/*
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30 = 4 + 5 + 6 + 7 + 8

*/

int SummNaturalNumber(int m, int n)
{
    if (m > n)
    {
        if (n > m) return 0;
        else return n + SummNaturalNumber(m, n + 1);
    }
    else if (m < n)
    {
        if (m > n) return 0;
        else return m + SummNaturalNumber(m + 1, n);
    }
    return m;
}

Console.Write("Задайте натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > 0 && numberN > 0)
{
    int summNaturalNumber = SummNaturalNumber(numberM, numberN);
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {summNaturalNumber}");
}
else Console.WriteLine("Введено некорректное значение!");