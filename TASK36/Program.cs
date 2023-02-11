// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
void SummaEvenNumbers(int[] array)
{
    int summ = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) summ += array[i];
    }
    System.Console.WriteLine(summ);
}

int[] arr = GenArray(5, -99, 100);
PrintArray(arr);
SummaEvenNumbers(arr);