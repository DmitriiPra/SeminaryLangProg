/* 
Алгоритм решения
1. ПРосим пользователя ввести чиcло 
3. Проверяеи равен ли 0 остаток при делении числа на 2
4. true -  выводим сообщение что  число четное
5. False  - выводим сообщение число нечетное 
*/

Console.WriteLine("Эта программа определяет является ли число четным");
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine($" Число {number} - четное.");
else Console.WriteLine($" Число {number} - Нечетное.");
