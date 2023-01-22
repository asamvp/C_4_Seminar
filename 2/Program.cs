/*Напишите программу, которая принимает на вход число и выдаёт количество 
цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
int Prompt(string message)
{
    Console.Write($"{message} -> ");
    int  result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int CountDigit(int a)
{
    int count=0;
    while (a>0)
    {
        a/=10;   
        count++;
    }
    return count;
}
Console.Clear();
int x=Prompt("Введите число");
Console.WriteLine($"Цифр в числе {x} равно {CountDigit(x)}");