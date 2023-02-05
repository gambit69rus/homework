// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string str = number.ToString();
int len = str.Length;
if (len == 5)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}