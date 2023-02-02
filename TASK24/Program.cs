/* 
принимает на вход число А
выдает сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36
*/

Console.Write("Введите натуральное число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
if (numberA < 0) System.Console.WriteLine("Введено неверное значение А");
else
{
    int SummaNumberA(int a)
    {
        int sum = 0;
        for (int i = 1; i <= a; i++) sum = sum + i;
        return sum;
    }

    int summaNumberA = SummaNumberA(numberA);
    Console.WriteLine($"{numberA} -> {summaNumberA}");
}