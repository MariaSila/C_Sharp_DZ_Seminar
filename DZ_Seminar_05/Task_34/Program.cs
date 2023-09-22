/*Задача 34: Задайте массив заполненный 
случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetArray (int length, int minValue, int maxValue)
{
    int [] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue,maxValue + 1); 
    }   
    return array;
}

int Prompt (string message)
{
    System.Console.Write(message);
    //string ReadInput = Console.ReadLine();
    int result = Convert.ToInt32(Console.ReadLine()!);
    return result;
}

void PrintArray (int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

int CountEvenNumbers (int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        int result = item % 2;
        if (result == 0)
            count += 1;
    
    }
    return count;
}

int length = Prompt("Введите количество элементов в массиве: ");
int [] array = GetArray(length, minValue:100, maxValue:999);
PrintArray(array);
System.Console.WriteLine($"Колличество четных чисел в массиве: {CountEvenNumbers(array)}");
