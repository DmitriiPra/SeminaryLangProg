/* 
принимает на вход число А
выдает сумму цифр в числе А
123 -> 6
-45 -> 9
*/

Console.Write("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
//if (numberA < 0) numberA *= -1;

int SummaNum(int a)
{
    if (a < 0) a *= -1;

    int amount = 0;
    while (a > 0)
    {
        amount += a % 10;
        a /= 10;
    }
    return amount;
}
int summaNum = SummaNum(numberA);
System.Console.WriteLine($"{numberA} -> {summaNum}");
