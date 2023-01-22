/*Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]*/
int Prompt(string message)
{
    Console.Write($"{message} -> ");
    int  result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] CreateArray(int x)
{
    int[] array = new int[x];
    for (int i=0; i<array.Length; i++)
    {
        array[i]= new Random().Next(0,2);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Clear();
int x = Prompt("Введите размер массива");
int[] array =CreateArray(x);
PrintArray(array);