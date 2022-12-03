/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int GetEvenNumberArray (int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array [i] % 2 == 0)
                {
                    count++;
                }
        }
    return count;
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

    int [] newArray = GetRandomArray (4, 100, 999);
    Console.ForegroundColor = ConsoleColor.Green;
    PrintArray (newArray);
    Console.ResetColor();
    int count = GetEvenNumberArray (newArray);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Количество четных чисел в массиве = {count}. ");
    Console.ResetColor();