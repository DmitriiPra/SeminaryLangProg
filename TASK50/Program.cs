/*
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого
элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого элемента в массиве нет
*/
Console.WriteLine("Укажите позицию искомого элемента: ");
Console.WriteLine("номер строки: ");
int rowN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("номер столбца: ");
int columnN = Convert.ToInt32(Console.ReadLine());

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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} |");
            else Console.WriteLine($"{matrix[i, j],3} |");
        }
    }
}
bool RequestVerification(int[,] matr, int row, int column)
{
    if (matr.GetLength(0)-1 < row || matr.GetLength(1)-1 < column) return false;
    return true;
}
void PrintResult(int[,] matrix, int row, int column, bool requestV)
{
    if (requestV == false) Console.WriteLine("такого элемента в массиве нет");
    else Console.WriteLine($" Значение заданного элемента массива = {matrix[row, column]}");
}
int[,] genMatrix = GenMatrix(3, 4, 0, 10);
PrintArray(genMatrix);
bool requestVerification = RequestVerification(genMatrix, rowN, columnN);
PrintResult(genMatrix, rowN, columnN, requestVerification);