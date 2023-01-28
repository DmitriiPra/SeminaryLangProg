// Принимает на вход номер четверти плоскости в которой находится точка
// Проверяет что Х и У не равны 0
// Выводит диапазон координат точки Х и У 

Console.Write("ВВедите номер четверти плоскости в которой находится точка: ");
string index = Console.ReadLine();

string Diapason(string ind)
{
    switch (ind)
    {
    case "1": return "диапазон координат точки: X > 0; Y > 0";
    case "2": return "диапазон координат точки: X < 0; Y > 0";
    case "3": return "диапазон координат точки: X < 0; Y < 0";
    case "4": return "диапазон координат точки: X > 0; Y < 0";
    default: return "Введены неверные данные";
    }
}
string diapason = Diapason(index);
Console.WriteLine(diapason);
