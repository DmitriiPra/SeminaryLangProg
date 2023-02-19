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
int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[index] = matrix[i, j];
            index++;
        }
    }
    Array.Sort(array);
    return array;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}] ");
}
void NumberOfIdenticalElements(int[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1]) count++;
        else
        {
            Console.WriteLine($"{arr[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"{arr[arr.Length-1]} встречается {count} раз");
}

int[,] genMatrix = GenMatrix(5, 3, 0, 15);
PrintArray2D(genMatrix);
Console.WriteLine();
int[] matrixToArray = MatrixToArray(genMatrix);
PrintArray(matrixToArray);
NumberOfIdenticalElements(matrixToArray);