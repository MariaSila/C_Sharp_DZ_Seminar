/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] GetArray (int length, int minValue, int maxValue)
{
    double[] array = new double [length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue) + new Random().NextDouble();
    }
    return array;
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)   
    {
        if (max < array[i])
            max = array[i];
    }
    return max;
}

double MinNumber (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
            min = array[i]; 
    }
    return min;
}

void PrintArray (double[] array)
{
    System.Console.Write("Массив: ");
    foreach (double item in array)
    {
        System.Console.Write($"{item:f} ");
    }
    System.Console.WriteLine();
}

double[] array = GetArray(length:10, minValue:0, maxValue:10);
PrintArray(array);
System.Console.WriteLine($"Max элемент массива: {MaxNumber(array):f}");
System.Console.WriteLine($"Min элемент массива: {MinNumber(array):f}");
System.Console.WriteLine($"Max - Min = {MaxNumber(array) - MinNumber(array):f}");
