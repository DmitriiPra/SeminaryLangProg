/*
Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 
*/

Console.WriteLine("Для вычисления функции Аккермана задайте 2 неотрицательных целых числа:");
Console.Write("число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int n, int m)
{
    if (n == 0) return m + 1;
    else if (m == 0) return AkkermanFunction(n - 1, 1);
    return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

if (numberM < 0 || numberN < 0)
{
    Console.WriteLine("Введено некорректное значение чисел!");
}
else
{
    int result = AkkermanFunction(numberM, numberN);
    Console.WriteLine($"M = {numberM}; N = {numberN} -> A(m,n) = {result}");
}