/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить
строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GenMatrix(int rows, int columns, int min, int max)
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
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        // Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
            else Console.WriteLine($"{matrix[i, j],3}");
        }
    }
}
int MinimumAmountRow(int[,] matrix)
{
    int indexRow = 1;
    int temp = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int amountRow = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            amountRow += matrix[i, j];
        }
        if (i == 0) temp = amountRow;
        else if (amountRow < temp)
        {
            indexRow = i;
            temp = amountRow;
        }
    }
    return indexRow;
}

int[,] genMatrix = GenMatrix(5, 3, -9, 9);
Console.WriteLine();
PrintArray(genMatrix);
int minimumAmountRow = MinimumAmountRow(genMatrix);
Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой элементов: {minimumAmountRow} строка");