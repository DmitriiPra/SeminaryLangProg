/* 
принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
верьткальный формат
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) Console.WriteLine("Введено неверное значение!");
else Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 5}  {Math.Pow(count, 3), 5}");
        count++;
    }
}