// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.Write("введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите число 3: ");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine("Максимальное число: " + number1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + number3);
    }

}
else if (number2 > number3)
{
    Console.WriteLine("Максимальное число: " + number2);
}
else
{
    Console.WriteLine("Максимальное число: " + number3);
}



