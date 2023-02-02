// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int startNumber = 1;

while (startNumber <= number)
{
    if (startNumber % 2 == 0)
        Console.Write(startNumber + ", ");
    startNumber++;
}