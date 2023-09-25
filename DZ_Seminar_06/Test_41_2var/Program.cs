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

//II второй вариант решения задачи с двумя функциями (ввод числа и подсчет)
int[] InputNumber(int enterNumbers)
{
    int [] massive =new int[enterNumbers];
    string error = "";
    for (int i = 0; i < enterNumbers; i++)
    {
        System.Console.Write(error + (i+1) + ": ");
        try
        {
            massive[i] = Convert.ToInt32(Console.ReadLine()!);
            error = "";
        }
        catch
        {
            error = "Введите повторно число ";
            i--;
        }
        
    }
    return massive;
}

int CountNumberPositive(int[] massive)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] >= 0)
            count++;
    }
    return count;
}



string number = "3";
int enterNumbers = Convert.ToInt32(number);
System.Console.WriteLine($"Введите {number} {GetNoun(number, "число", "числа", "чисел")}");
int array = CountNumberPositive(InputNumber(enterNumbers));
System.Console.WriteLine($"Колличество введеных чисел больше нуля =  {array}");