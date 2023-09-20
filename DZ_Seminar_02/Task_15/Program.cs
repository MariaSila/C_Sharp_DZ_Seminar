/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

System.Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine()!);
if (day > 5 & day < 8)
{
    System.Console.WriteLine("Да");
}
else if (day > 0 & day < 6)
{
    System.Console.WriteLine("Нет");
}
else
{
    System.Console.WriteLine("Ошибка! Введите число от 1 до 7");
}