/*
выводит случайное трёхзначное число и 
удаляет вторую цифру этогочисла.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNum = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число = {randomNum}");

int NumberConversion(int num)
{
    return num / 100 * 10 + num % 10;
}
Console.WriteLine($"Преобразованное число = {NumberConversion(randomNum)}");
