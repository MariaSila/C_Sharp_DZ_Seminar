/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/


int NumberDegree(int numberA, int numberB)
{
  int result = 1;
  int count = 1;
  while (count <= numberB)
  {
    result *= numberA;
    count ++;
  }
  return result;
}

System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine()!);
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine()!);
System.Console.WriteLine($"Число {numberA} в {numberB} степени = {NumberDegree(numberA, numberB)}");
