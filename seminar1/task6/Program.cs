// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


if (number % 2 == 0)
{
    Console.WriteLine(number + " - Четное число: ");
}
else
{
    Console.WriteLine(number + " - Нечетное число");
}