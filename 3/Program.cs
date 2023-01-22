/*Задача 2: Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/
int Prompt(string message)
{
    Console.Write($"{message} -> ");
    int  result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int Factorial(int a)
{
    int count=1;
    int fact=1;
    while (count<=a)
    {
        fact=fact*count;
        count++;
    }
    return fact;
}
Console.Clear();
int x=Prompt("Введите число N");
Console.WriteLine($"Произведение чисел от 1 до {x} равно {Factorial(x)}");