Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1) Console.WriteLine("Введено неверное значение натурального числа!");
else Table(number);

void Table(int num)
{
    int count = 1;
    while (count <= num)
    {
        System.Console.WriteLine($"{count, 5}  {Math.Pow(count, 2), 5}");
        count++;
    }
}