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
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
            else Console.WriteLine($"{matrix[i, j],3}");
        }
    }
}
int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            matrixC[i, j] = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

int[,] genMatrix1 = GenMatrix(2, 3, 0, 3);
PrintArray(genMatrix1);
Console.WriteLine();
int[,] genMatrix2 = GenMatrix(3, 2, 0, 3);
PrintArray(genMatrix2);
Console.WriteLine();
if (genMatrix1.GetLength(1) != genMatrix2.GetLength(0))
{
    Console.WriteLine("Умножение матриц не возможно!");
    Console.WriteLine("Количество столбцов первой матрицы должно"
        + " быть равно количеству строк второй матрицы.");
}
else
{
    int[,] matrixMultipli = MatrixMultiplication(genMatrix1, genMatrix2);
    PrintArray(matrixMultipli);
}