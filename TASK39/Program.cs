// Программы переворачивающая одномерный массив
//  [1 2 3 4 5 6] -> [6 5 4 3 2 1]

int[] GenArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}] ");
}
void MirrorArray(int[] arr)
{
    int temp = default;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}
int[] array = GenArray(5, -99, 100);
PrintArray(array);
Console.Write(" -> ");
MirrorArray(array);
PrintArray(array);