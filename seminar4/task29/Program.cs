// Задача 29: Напишите программу, которая задаёт размер массива и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("введите размер массива: ");
int lenArray = int.Parse(Console.ReadLine()!);

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(0, 100);
    Console.Write(randomArray[i] + " ");
}

