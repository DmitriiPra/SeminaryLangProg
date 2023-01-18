/* 
принимает на вход число и 
проверяет, кратно ли оно одновременно 7 и 23.
*/

bool CheckingMultiplicity(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckingMultiplicity(number);

if (result == true) Console.WriteLine("КРАТНО");
else Console.WriteLine($"НЕ КРАТНО");
