// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);
int max = number1;
if (number1 > number2)
{
    Console.Write(max = number1);
}
else
    Console.Write(max = number2);
