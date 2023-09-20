/* Задача 27: Напишите программу, которая принимает
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumDigit(int number)
{
    int sum = 0;
    int digit = 0;
    while (number > 0)
    {
        digit = number % 10;        // 7298 % 10 = 8
        sum += digit;               // 0+8=8
        number = number / 10;       // 7298 / 10 = 729
    }
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine($"Сумма цифр числа {number} = {SumDigit(number)}");