/*Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

System.Console.WriteLine("Введите числа для следующих значений:");

int[] InputValue(int length)
{
    string[] values = {"k1", "k2", "b1", "b2"};
    int[] array = new int[length];
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(values[i] + ": ");
            array[i] = Convert.ToInt32(Console.ReadLine()!);
            if ((i==1)&&(array[i] == array[i-1]))
            {
                System.Console.WriteLine($"Значения совпадают, введите разные значения для {values[i - 1]} и {values[i]}");
                i--;
            }
        }      
    return array;  
}

double[] PointCross(int[] array)
{
    double[] point = new double [2];
    double k1 = array[0];
    double k2 = array[1];
    double b1 = array[2];
    double b2 = array[3];

    point[0] = (b2 - b1) / (k1 - k2) ;
    point[1] = k1 * point[0] + b1;
  
    return point;
}

/*void PrintArray (double [] array)
{
    foreach (double item in array)
    {
        System.Console.Write($"{item:f2} ");
    }
    System.Console.WriteLine();

}
*/

int length = 4;
int[] values = InputValue(length);
double[] massive = PointCross(values);
System.Console.Write($"Точка пересечения двух прямых ({massive[0]:f}, {massive[1]:f}).");

