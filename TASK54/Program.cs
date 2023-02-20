/*
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.

1 4 7 2
5 9 2 3
8 4 2 4
   v
7 4 2 1
9 5 3 2
8 4 4 2
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
void SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int temp = default;
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
}

int[,] genMatrix = GenMatrix(3, 6, -9, 9);
Console.WriteLine();
PrintArray(genMatrix);
SortMatrix(genMatrix);
Console.WriteLine();
PrintArray(genMatrix);
Console.WriteLine();
