/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int numberA = 22;
int numberB = 3;
int numberC = 9;
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine($"max = {max}");