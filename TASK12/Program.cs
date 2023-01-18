/*
принимать на вход два числа и 
выводить, является ли первое число
кратным второму. 
Если число 1 не кратно числу 2, то
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.Write("Введите 2 числa: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

int CheckingMultiplicity(int numA, int numB)
{
    return numA % numB;
}

int result = CheckingMultiplicity(numberA, numberB);
if (result == 0) Console.WriteLine("КРАТНО");
else Console.WriteLine($"НЕ КРАТНО, остаток = {result}");
