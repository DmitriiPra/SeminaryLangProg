/* 
принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
*/

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondNum(int num)
{
    return num / 10 % 10;
}

int secondChar = SecondNum(number);
Console.WriteLine($"Cредняя цифра = {secondChar}");
