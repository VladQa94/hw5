/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

 int[] GetRandomArray (int length, int min, int max)
{
    int [] array = new int [length];
    for (int i = 0; i < length; i++)
    {
         array [i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int GetSumOfOddIndex (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }                
    }
    return sum;
}

int [] newArray = GetRandomArray (10, -10, 10);
Console.ForegroundColor = ConsoleColor.Green;
PrintArray (newArray);
Console.ResetColor();
int summa = GetSumOfOddIndex (newArray);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях = {summa}.");
Console.ResetColor();
