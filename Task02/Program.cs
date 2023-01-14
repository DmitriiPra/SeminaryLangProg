/* Алгоритм
1. Введите число определяющее день недели
2. Проверка числа оператором switch c присваиванием имени дня недели
3. действие при неверном вводе данных
4. Вывод результата в консоль
 */

Console.Write("Введите целое число от 1 до 7, определяющее день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 1) Console.WriteLine("Число 1 это Понедельник");
else if(number == 2) Console.WriteLine("Число 2 это Вторник");
else if(number == 3) Console.WriteLine("Число 3 это Среда");
else if(number == 4) Console.WriteLine("Число 4 это Четверг");
else if(number == 5) Console.WriteLine("Число 5 это Пятница");
else if(number == 6) Console.WriteLine("Число 6 это Суббота");
else if(number == 7) Console.WriteLine("Число 7 это Воскресенье");
else Console.WriteLine($"Вы ввели неверное значение! Число {number} НЕ ЯВЛЯЕТСЯ числом, определяющим день недели");


 
	// switch (grade) {
   	//     case 5:
    //    		System.out.println("Otlichno!");
    //        break;
   	//     case 4:
    //        	System.out.println("Khorosho!");
    //        break;
    //    	    case 3:
 	//     .
	//     .
	//     .
   	//     default:
    //        System.out.println("Nevernaya otsenka");
	// }