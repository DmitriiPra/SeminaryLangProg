/* 
Алгоритм решения
1. ПРосим пользователя ввести чиcло A
2. ПРосим пользователя ввести чиcло B
3. Если А > B - выводим сообщение что большее число = А
4. Иначе если В > А - выводим сообщение что большее число = В
5. Иначе  - выводим сообщение что А = В
*/

Console.WriteLine("Эта программа определяет большее число");
Console.Write("Введите первое число: ");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
double numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine($"Большее число = {numberA}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"Большее число = {numberB}");
}
else Console.WriteLine($"Числа равны");
