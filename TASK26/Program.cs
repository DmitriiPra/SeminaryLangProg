/* 
принимает на вход число А
выдает количество цифр в чисел А
743 -> 3
45 -> 2
82542 -> 5
*/

Console.Write("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine());

int Quantity(int a)
{
    if (a < 0) a *= -1;
    int count = 0;
    if (a == 0) return count =1;
    for (int divider = 10; a > 0; count++)
        a /= divider;
    return count;
}
int quantity = Quantity(numberA);
System.Console.WriteLine($"{numberA} -> {quantity}");