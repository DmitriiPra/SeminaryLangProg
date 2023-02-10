// выводит массив из 8 элементов и выводит их на экран:
//12, 2, 46, 54, 36, 78, 6, 64 -> [12, 2, 46, 54, 36, 78, 6, 64] 

int[] GenArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr [i] = rand.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length - 1]);
}

int[] array = GenArray(8, 0, 99);
PrintArray(array);
Console.Write(" -> [");
PrintArray(array);
Console.WriteLine("]");