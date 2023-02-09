// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите числоA: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите числоB: ");
int numberB = int.Parse(Console.ReadLine()!);
ToDegree(numberA, numberB);

// Функция возведения в степень
void ToDegree(int numberA, int numberB)
{
    int result = 1;
    for (int count = 1; count <= numberB; count++)
    {
        result = result * numberA;
    }
    Console.WriteLine(result);
}