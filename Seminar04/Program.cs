// Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*
int GetSum (int num)
{
    int sum = 0;
    for(int current = 1; current <= num; current++)
    {
        sum += current;
 //     sum = sum + current;
    }
    return sum;
}

Console.Clear();
Console.Write("Ввидите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());

int  result = GetSum(a);

Console.WriteLine("Сумма чисел от 1 до введенного числа: " + result);
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


/* int GetNum (int num)
{
    int numbers = 0;
    while (num != 0)
    {
        num = num / 10;
        numbers++;
    }

    return numbers;
}

Console.Clear();
Console.Write("Ввидите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int  result = GetNum(number);

Console.WriteLine("Количество цифр в введенном числе: " + result); */


// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N

/*
int GetMulti (int num)
{
    int multi = 1;
    for(int current = 1; current <= num; current++)
    {
        multi *= current;
 
    }
    return multi;
}

Console.Clear();
Console.Write("Ввидите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

int  result = GetMulti(n);

Console.WriteLine("Произведение чисел от 1 до введенного числа: " + result);
*/

// Одномерные массивы

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);

// Задача 4. 