/* 
выводит третью цифру заданного числа или 
сообщает, что третьей цифры нет
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int ChoiceNum(int num)
{
    num = num/100;
    if (num > 0) num = num % 10;
    else num = -1;
    return num;
}

int selectChar3 = ChoiceNum(number);
if (selectChar3 == -1) Console.WriteLine("Третья цифры в этом числе нет");
else Console.WriteLine($"Третья цифра в этом числе = {selectChar3}");    