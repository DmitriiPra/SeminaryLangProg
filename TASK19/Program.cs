/*  
принимает на вход пятизначное число 
(выполнено решение для любого количесво знаков в числе) 
и  проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да

234567765432 - да
12 - нет
*/

Console.Write("Введите целое число, проверим является ли оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10 && number > -10) Console.WriteLine("Введено число, состоящее из 1 знака, такое число проверке не подлежит.");
else
{
    //вычисляем количество знаков:
    int QuantityN(int num)
    {
        int count = 1;
        int a = 10;
        while (num > a)
        {
            count++;
            a *= 10;
        }
        return count;
    }
    int quantityN = QuantityN(number);

    int MirrorNumber(int numb, int quan)
    {
        int tempN = numb;
        int mirrorN = 0;
        int count = 1;
        int remains = 0;

        while (count < quan)
        {
            remains = tempN % 10;
            tempN = tempN / 10;
            mirrorN = (mirrorN + remains) * 10;
            count++;
        }
        return mirrorN = mirrorN + tempN;
    }
    int mirrorNumber = MirrorNumber(number, quantityN);

    if (number == mirrorNumber) Console.WriteLine($"ДА, число {number} является палиндромом");
    else Console.WriteLine($"НЕТ, число {number} не является палиндромом");
}