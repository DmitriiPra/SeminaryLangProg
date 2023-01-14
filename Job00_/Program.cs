/* 
Алгоритм:
1. На вход принимает число
2. рассчитывает квадрат этого числа
3. вывод результат 
*/
Console.Write("введите целое число: ");
int numA = Convert.ToInt32(Console.ReadLine()); //команда Convert.ToInt32() конвертирует аргумент типа String в число типа Int
int square = numA * numA;
Console.WriteLine($"Квадрат числа {numA} = {square}"); //интерполяция строк