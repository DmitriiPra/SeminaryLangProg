/* Алгоритм
1. ввод числа 1
2. ввод числа 2
3. проверка является ли первое число квадратом второго
4. Вывод результата в консоль
 */

Console.Write("Введите значение числа 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение числа 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == (number2 * number2))
{
    Console.WriteLine($"Число {number1} ЯВЛЯЕТСЯ квадратом числа {number2}");
}
else
{
    Console.WriteLine($"Число {number1} НЕ ЯВЛЯЕТСЯ квадратом числа {number2}");
}