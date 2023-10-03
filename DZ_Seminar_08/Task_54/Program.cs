/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] GetArray(int n, int m, int minValue = 1, int maxValue = 99)
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

void SortedArray(int[,] array)
{
for (int k = 0; k < array.GetLength(1) - 1; k++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp;
            if (array[i, j] < array[i, j + 1])
            {
                temp = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }
    }
}
}


int[,] matrix = GetArray(4, 5);
PrintArray(matrix);
SortedArray(matrix);
PrintArray(matrix);
System.Console.WriteLine(matrix[0, 0]);