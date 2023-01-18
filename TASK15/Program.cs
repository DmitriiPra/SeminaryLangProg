/*
принимает навход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.

Принимаем что:  1 пн ... 5 пт - будни
                6 сб, 7 вс - выходные
*/

string DefinitionDay(int num)
{
    string day = "void";
    if (num > 0 && num < 6) day = "Будний день";
    else if (num < 8) day = "Выходной день";
    else day = "Введено неверное число";
    return day;
}

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int dayWeek = Convert.ToInt32(Console.ReadLine());

string answer = DefinitionDay(dayWeek);
Console.WriteLine(answer);