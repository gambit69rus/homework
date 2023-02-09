// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int len = NumberLen(number);
SumNumbers(number, len);

int NumberLen(int number)
{
    int index = 0;
    while (number > 0)
    {
        number /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int number, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += number % 10;
        number /= 10;
    }
    Console.WriteLine(sum);
}