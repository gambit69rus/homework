// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int size = 4;
int min = 1;
int max = 100;
int[] arr = GetArray(size, min, max);
PrintArray(arr);
int maxNumber = arr[0];
int minNumber = arr[0];
int[] GetArray(int length, int min, int max)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max - 1);
    return res;
}
void PrintArray(int[] someArray)
{
    Console.Write("[");
    for (int i = 0; i < someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxNumber)
    {
        maxNumber = arr[i];
    }
    if (arr[i] < minNumber)
    {
        minNumber = arr[i];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным числом = {maxNumber - minNumber}");

