// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int size = 10;
int min = 100;
int max = 1000;
int result = 0;
int[] arr = GetArray(size, min, max);
PrintArray(arr);
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
    if (arr[i] % 2 == 0)
    {
        result++;
    }
}
Console.WriteLine($"В массиве {result} четных чисел");



