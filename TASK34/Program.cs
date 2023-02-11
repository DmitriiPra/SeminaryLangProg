// Задайте массив заполненный случайными положительными трёхзначными числами.
// показать количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    Console.Write($"{arr[arr.Length - 1]}] -> ");
}
void EvenNumbered(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    System.Console.WriteLine(count);
}

int[] arr = GenArray(5, 100, 999);
PrintArray(arr);
EvenNumbered(arr);