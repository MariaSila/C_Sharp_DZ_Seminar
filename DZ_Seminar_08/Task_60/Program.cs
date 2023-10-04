/*
.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2

66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


int[,,] Get3DArrayUnicElement(int x, int y, int z, int minValue = 10, int maxValue = 99)
{
    int[,,] array3D = new int[x, y, z];
    int[] massive = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int[,,] error = {{{-1,-1, -1,}, {-1,-1, -1,}, {-1,-1, -1,}}};
    int twoDigitNumbers = 90;
    if (massive.Length > twoDigitNumbers)
    {
        return error;
    }
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue + 1);
        if (i > 1)
            for (int j = 0; j < i; j++)
            {
                while (massive[i] == massive[j])
                {
                    massive[i] = new Random().Next(minValue, maxValue + 1);
                    j = 0;
                }
            }
    }
    
    int count = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = massive[count];
                count++;
            }
        }
    }
    return array3D;
}

void Print3DArray(int[,,] array)
{
    int error = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == error)
            {
                System.Console.WriteLine("Ошибка! Матрица превышает возможные значения из неповторяющихся положительных двухзначных чисел.");
                System.Console.WriteLine();
                return;
            }
                System.Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}

int[,,] massive = Get3DArrayUnicElement(2, 5, 9);
Print3DArray(massive);
