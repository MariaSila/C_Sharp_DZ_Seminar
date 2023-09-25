/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

string GetNoun(string number, string one, string two, string five)
{
    int n = Convert.ToInt32(number);
    n %= 100;
    if (n >= 5 && n <= 20)
        return five;
        
    n %= 10;
    if (n >= 2 && n <= 4)
        return two;
    if (n == 1)
        return one;
    return five;       
}

//I вариант решения задачи: функция для ввода и одновременного подсчета положительных чисел.
int InputCountPositiveNumber(int enterNumbers)
{
    int count = 0;
    for (int i = 0; i < enterNumbers; i++)
    {
        System.Console.Write((i+1) + ": ");
        int readNumber = Convert.ToInt32(Console.ReadLine()!);
            if (readNumber > 0)
                count++;
        
    }
    System.Console.Write("Колличество введеных чисел больше нуля = ");
    return count;
}

string number = "3";
int enterNumbers = Convert.ToInt32(number);
System.Console.WriteLine($"Введите {number} {GetNoun(number, "число", "числа", "чисел")}");
System.Console.WriteLine(InputCountPositiveNumber(enterNumbers));
