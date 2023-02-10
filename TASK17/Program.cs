// Принимает на вход координаты точки Х и У
// Проверяет что Х и У не равны 0
// Выводит номер четверти плоскости в которой находится точка

Console.WriteLine("Введите координаты:");
Console.Write("X = ");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.Write("Y = ");
int coordY = Convert.ToInt32(Console.ReadLine());

int Index(int cX, int cY)
{
    if (cX > 0 && cY > 0) return 1;
    if (cX < 0 && cY > 0) return 2;
    if (cX < 0 && cY < 0) return 3;
    if (cX > 0 && cY < 0) return 4;
    return 0;
}

int index = Index(coordX, coordY);
string result = index != 0 ?
        $"координаты относятся к {index} четверти"
        : "Х или У равно 0";
Console.WriteLine(result);
