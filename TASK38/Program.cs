// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] GenArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return arr;
}
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}] -> ");
}
double DifferenceNumbersMaxMin(double[] array)
{
    double maxNumber = default;
    double minNumber = array[0];
    double difference = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        if (array[i] < minNumber) minNumber = array[i];
    }
    return difference = Math.Round((maxNumber - minNumber), 1);
}

double[] arr = GenArray(5, 0, 100);
PrintArray(arr);
Console.WriteLine(DifferenceNumbersMaxMin(arr));