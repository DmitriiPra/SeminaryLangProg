/* 
принимает на вход число А и В и
возводит чисело А в натуральную степень B

3, 5 -> 243
2, 4 -> 16
*/

Console.Write("Введите число А:");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число B:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) System.Console.WriteLine("Введено неверное значение B");
else
{
    double DegreeA(double a, int b)
    {
        double res = 1;
        for (int i = 1; i <= b; i++) res *= a;
        return res;
    }

    double degreeA = DegreeA(numberA, numberB);
    Console.WriteLine($"{numberA}, {numberB} -> {degreeA}");
}

//Math.Pow((z1 - z2), 2))