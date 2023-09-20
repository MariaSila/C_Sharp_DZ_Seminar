/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
123456789 -> 3
*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()!);
int thirdDigit = -1;
while (number >= 1000)
{
    number = number / 10;
} 
int result = number; 
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
} 
else
{
    thirdDigit = result % 10;
    Console.WriteLine(thirdDigit);
}   
