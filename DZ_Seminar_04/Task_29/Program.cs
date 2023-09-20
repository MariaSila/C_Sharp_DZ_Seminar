/*Задача 29: Напишите программу, 
которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

System.Console.Write("Введите минимальное значение: ");
int minValue = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write($"Введите максимальное значение: ");
int maxValue = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write($"Введите количество элементов в массиве: ");
int length = Convert.ToInt32(Console.ReadLine()!);

int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(minValue, maxValue + 1);
}
for (int i = 0; i < length; i++)
{
    if (i < length-1)
    System.Console.Write(array[i] + ", ");
    else
    System.Console.Write(array[i]);
}

