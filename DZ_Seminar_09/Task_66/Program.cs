/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

int SumDigitsInInterval(int m, int n)
{
    if (m == n)
        return m;
    int result = m + SumDigitsInInterval(m + 1, n);
    return result;
}

System.Console.WriteLine(SumDigitsInInterval(4, 8));