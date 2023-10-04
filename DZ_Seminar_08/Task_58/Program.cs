/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
    int error = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[0, 0] == error)
            {
                System.Console.WriteLine("Ошибка! Количество столбцов первой матрицы должно равняться количеству строк второй матрицы.");
                System.Console.WriteLine();
                return;
            }
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] ProductOfMatrix(int[,] array, int[,] multiplier)
{
    int[,] product = new int[array.GetLength(0), multiplier.GetLength(1)];
    int[,] error = {
        {-1, -1}, 
        {-1, -1},
    };
    if (array.GetLength(1) != multiplier.GetLength(0))
    {
        return error;
    }
    for (int i = 0; i < product.GetLength(0); i++)
    {
        
        for (int j = 0; j < multiplier.GetLength(1); j++)
        {
            int el_product = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                el_product += array[i, k] * multiplier[k, j];
            }
            product[i, j] = el_product;
        }
    } 
    return product;
}

int[,] matrix_1 = GetArray(4, 3);
System.Console.WriteLine("Первая матрица:");
PrintArray(matrix_1);
int[,] matrix_2 = GetArray(3, 2);
System.Console.WriteLine("Вторая матрица:");
PrintArray(matrix_2);
int[,] product_matrix = ProductOfMatrix(matrix_1, matrix_2);
System.Console.WriteLine("Произведение двух матриц:");
PrintArray(product_matrix);

