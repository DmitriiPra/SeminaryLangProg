/* 
принимает на вход число N
выдает факториал числа N
4 -> 24
5 -> 120

*/

Console.Write("Введите число натуральное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

int Factorial(int a)
{
    int result = 1;
    for (int i = 1; i <= a; i++) result *= i;
    return result;
}

if (numberN > 0)
{
    int factorialN = Factorial(numberN);
    Console.WriteLine($"Факториал {numberN} -> {factorialN}");
}
else Console.WriteLine("Введено неверное значение N");
