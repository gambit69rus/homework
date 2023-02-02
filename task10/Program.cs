// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int result = ((number / 10) % 10);
if ((number > 100) && (number < 1000))
{
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine("вы ввели не трехзначное число");
}