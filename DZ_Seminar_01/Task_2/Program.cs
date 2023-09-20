/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите два разных числа: ");
int numberA = Convert.ToInt32(Console.ReadLine()!);
int numberB = Convert.ToInt32(Console.ReadLine()!);
if (numberA > numberB)
{
    Console.WriteLine($"max = {numberA}");
    Console.WriteLine($"min = {numberB}");
}
else if (numberB > numberA)
{
    Console.WriteLine($"max = {numberB}");
    Console.WriteLine($"min = {numberA}");
}
else
{
    Console.WriteLine("Ошибка! Необходимо вводить разные числа.");
}
