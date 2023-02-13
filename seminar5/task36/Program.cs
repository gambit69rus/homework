// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int size = 4;
int min = -100;
int max = 100;
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
    if (i % 2 != 0)
    {
        result += arr[i];
    }
}
Console.WriteLine($"Сумма элементов нечетных позиций = {result}");