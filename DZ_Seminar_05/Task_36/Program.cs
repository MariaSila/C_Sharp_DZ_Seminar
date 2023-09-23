/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int Prompt (string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine()!);
    return result;
}

int[] GetArray (int length, int minValue, int maxValue)
{
    int[] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write(item + " ");
    }
    System.Console.WriteLine();
}

int SumNumberOddPosition (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int length = Prompt("Введите количество элементов в массиве: ");
int [] array = GetArray(length, minValue:1, maxValue:99);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечетных позициях: {SumNumberOddPosition(array)}");