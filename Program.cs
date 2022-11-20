//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223 -> 4
/*
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int CoutnPositiv(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] Array = GetArrayFromString(input);
int countNum = CoutnPositiv(Array);
Console.WriteLine($"Количество положительных чисел равно: {countNum}");
*/


//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b1 - b2)/(k2 - k1);
double y = k2 * x + b2;

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
*/

