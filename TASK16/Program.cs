/* принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
*/

bool CheckingMultiplicity(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1;
}

Console.WriteLine("введите два числа: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());

bool result = CheckingMultiplicity(numberA, numberB);
if (result == true) Console.WriteLine("является");
else Console.WriteLine("Не является");
