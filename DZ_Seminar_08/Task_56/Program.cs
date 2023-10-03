/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] GetArray(int n, int m, int minValue = 1, int maxValue = 9)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintSumLines (int[] array)
{
    System.Console.Write("Сумма строк: [ ");
    foreach (double item in array)
    {
        System.Console.Write(item + " ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int[] SumRowElements(int[,] array)
{
    int[] massive = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        massive[i] = sum;
    }
    return massive;
}

int LineWithMinSum(int[] massive)
{
    int min = massive[0];
    int index_min = 0;
    for (int i = 1; i < massive.Length; i++)
    {
        if (min > massive[i])
        {
            min = massive[i];
            index_min = i + 1;
        }
    }
    return index_min;
}


int[,] matrix = GetArray(8, 3);
PrintArray(matrix);
int[] sumRows = SumRowElements(matrix);
PrintSumLines(sumRows);
System.Console.WriteLine($"Cтрока с наименьшей суммой элементов: {LineWithMinSum(sumRows)} строка.");