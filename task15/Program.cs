﻿// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine()!);
string str = number.ToString();
if ((number > 0) && (number < 8))
{
    if ((number == 6) || (number == 7))
    {
        Console.WriteLine($"{number} ->да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}
else
{
    Console.Write("Вы ввели число не в пределах от 1 до 7, поэтому не возможно определить");
}
