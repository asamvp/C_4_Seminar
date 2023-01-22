//Задача 1

int Prompt(string message)
{
    Console.Write($"{message} >");
    int  result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int SumNumbers(int number)
{
    int sum=0;
    for(int i=1; i<=number; i++)
    {
        sum +=i;
    }
    return sum;
}
int SumNumberGauss(int number)
{
    return(number +1)*number/2;
}
int number = Prompt("Введите число");
int sum = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна {sum}");
Console.WriteLine($"Сумма чисел по гауссу от 1 до {number} равна {SumNumberGauss(number)}");