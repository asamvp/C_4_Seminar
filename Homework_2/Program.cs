/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
int Prompt(string message)
{
    Console.Write($"{message} -> ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int SumCifr(int a)
{
    int buffer = 0;
    while (a > 0)
    {
        buffer = buffer + a % 10;
        a /= 10;
    }
    return buffer;
}

Console.Clear();
int x = Prompt("Введите число N");
Console.WriteLine($"Сумма цифр в числе {x} равно {SumCifr(x)}");