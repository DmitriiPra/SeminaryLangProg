﻿// отразить поседнюю цифру введенного трехзначного числа
/* 
Алгоритм решения
1. ПРосим пользователя ввести трехзначное чиcло N
2. Проверяем является ли введенное число трехзначным числом, в случае несоответствия вводим сообщение
3. Вводим переменную number = -1 * N
4. включам цикл, условия которого пока numner < N  
5. Выводим в консоль в одну строку значения number
6. увеличиваем number на 1 
7. Выводим в консоль последнее значение N  без запятой
*/

Console.Write("Введите натуральное число N: ");
int numN = Convert.ToInt32(Console.ReadLine());