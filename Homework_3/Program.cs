/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

//странное задание, не совсем понял зачем это и как.....)))


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
        array[i]= new Random().Next(0,1000);
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
int x = Prompt("Введите размер массива, например из 8 элементов ))))");
int[] array =CreateArray(x);
PrintArray(array);