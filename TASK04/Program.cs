/* 
Алгоритм решения
1. ПРосим пользователя ввести чиcло A
2. ПРосим пользователя ввести чиcло B
3. ПРосим пользователя ввести чиcло C
4. Проверяем, нет ли равных чисел, если есть - сообшаем об ошибке ввода,если нет - запускаем условие, 
5. Если А > B, то сравниваем А с С и  выводим сообщение какое число большее
6. Иначе если В > А, то сравниваем В с С и выводим сообщение какое число большее
*/

Console.WriteLine("Эта программа определяет большее число из трех");
Console.Write("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, отличное от первого: ");
double numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число, отличное от первого и второго: ");
double numberC = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB || numberA == numberC || numberB == numberC)
{
    Console.WriteLine("Не верный ввод данных");
}
else if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine($"Большее число = {numberA}");
    }
    else Console.WriteLine($"Большее число = {numberC}");
}
else if (numberB > numberC) 
{
    Console.WriteLine($"Большее число = {numberB}");
}
else Console.WriteLine($"Большее число = {numberC}");

