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