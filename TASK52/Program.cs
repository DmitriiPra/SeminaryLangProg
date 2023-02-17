/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] GenMatrix(int rows, int columns, int min, int max) //matrix
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
void PrintArray2D(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.WriteLine($"{matrix[i, j],3} |");
        }
    }
}
double[] ArithmeticMeanColumns(int[,] matrix)
{
    double[] arrayResults = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = default;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];
        }
        arrayResults[j] = Math.Round(result / matrix.GetLength(0), 1);
    }
    return arrayResults;
}
void PrintArrayResults(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}.");
}

int [,] genMatrix = GenMatrix(2, 4, 0, 10);
PrintArray2D(genMatrix);
Console.WriteLine("");
double[] arithmeticMeanColumns = ArithmeticMeanColumns(genMatrix);
PrintArrayResults(arithmeticMeanColumns);