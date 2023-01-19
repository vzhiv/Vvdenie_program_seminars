// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* int FindPositive(int num)
{
    int positive = 0;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i+1} число из {num} чисел: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0) positive++;
    }

    return positive;
}


Console.Clear();
Console.Write("Введите какое количество чисел вы будете вводить: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 0)
{
    int count = FindPositive(num);
    Console.WriteLine($"Вы ввели {count} чисел больше 0");
}
else Console.WriteLine("Вы ввели не верные данные"); */


// Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/* double FindDotX(double k1, double b1, double k2, double b2)
{
    double dotX = (b2-b1)/(k1-k2);
    return dotX;
}

double FindDotY(double k1, double b1, double x)
{
    double dotY = k1*x + b1;
    return dotY;
}

Console.Clear();
Console.WriteLine("Есть 2 уравнения: y = k1 * x + b1, y = k2 * x + b2 ");
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if( k1 != k2)
{
    double dotX = FindDotX(k1,b1,k2,b2);
    double dotY = FindDotY(k1,b1,dotX);
    Console.WriteLine($"Точка пересечения линий: X = {dotX} , Y = {dotY}");
}
else Console.WriteLine("Линии параллельны друг другу и НЕ пересекаются"); */





