/*Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
//arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);

double[,] GenMatrix(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max-min) + min), 2);
        }
    }
    return matrix;
}
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($" {matrix[i, j], 5} |");
            else Console.WriteLine($" {matrix[i, j], 5} |");
        }
    }
}
double[,] genMatrix = GenMatrix(3, 4, -10, 10);
PrintArray(genMatrix);