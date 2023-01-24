/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int Prompt(string message)
{
    Console.Write($"{message} -> ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Step(int a, int b)
{
    int count = 1;
    int result = a;
    while (count < b)
    {
        result = result * a;
        count++;
    }
    return result;
}
Console.Clear();
int a = Prompt("Введите число A");
int b = Prompt("Введите степень для числа А");
Console.WriteLine($"Число {a} в степени {b} равно {Step(a, b)}");