// Пользователь вводит М чисел
// определить сколько из введенных чисел больше 0
// 1, -20, 7, -2, -3 -> 2

Console.WriteLine("Задайте количество обрабатываемых чисел: ");
int sizeM = Convert.ToInt32(Console.ReadLine());

int[] NumbersArray(int size)
{
    int[] numbersArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        numbersArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return numbersArray;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]} -> ");
}
void ResultCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine(count);
}

int[] numbersArray = NumbersArray(sizeM);
PrintArray(numbersArray);
ResultCount(numbersArray);