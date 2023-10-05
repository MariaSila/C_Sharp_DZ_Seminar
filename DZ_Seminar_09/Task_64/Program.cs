/*
Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"

*/

void ShowNumbers(int m, int n)
{
    if (m > n) 
    {
        System.Console.WriteLine("Ошибка! Введните повторно значение m и n (где m < n) для функции ShowNumbers.");
        return;
    }

    if (m == n)
    {
        System.Console.Write(n);
        return;
    }

    System.Console.Write(m + ", ");
    ShowNumbers(m + 1, n);
}

ShowNumbers(9, 10);
