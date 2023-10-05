/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29
*/

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermannFunction(m - 1, 1);
    
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

System.Console.WriteLine(AckermannFunction(3, 2));