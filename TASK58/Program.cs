/*
Задайте две матрицы. 
Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
int[,] AmountMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] amountMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     int temp = default;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int amountRow = default;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             amountRow += matrix[i, j];
//         }
//         if (i == 0) temp = amountRow;
//         else if (amountRow < temp)
//         {
//             indexRow = i;
//             temp = amountRow;
//         }
//     }
    return amountMatrix;
}

int[,] genMatrix1 = GenMatrix(5, 3, 0, 5);
Console.WriteLine();
PrintArray(genMatrix1);
int[,] genMatrix2 = GenMatrix(3, 5, 0, 5);
Console.WriteLine();
PrintArray(genMatrix2);
// int minimumAmountRow = MinimumAmountRow(genMatrix);
// Console.WriteLine();
// Console.WriteLine($"номер строки с наименьшей суммой элементов: {minimumAmountRow} строка");
