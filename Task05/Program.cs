/* 
Алгоритм решения
1. ПРосим пользователя ввести значение чиcла N
2. Проверяем что число является натуральным числом, в случае несоответствия вводим сообщение
3. Вводим переменную number = -1 * N
4. включам цикл, условия которого пока numner < N  
5. Выводим в консоль в одну строку значения number
6. увеличиваем number на 1 
7. Выводим в консоль последнее значение N  без запятой
*/

Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numN > 0)
{
    int number = -1 * numN;
    while (number < numN)
    {
        Console.Write($"{number}, ");
        number++;
    }
    Console.WriteLine(number);
}
else Console.WriteLine("Введено НЕВЕРНОЕ значение N!");