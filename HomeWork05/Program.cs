// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/* int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
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

int CountEvenNumberInArray(int[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++) 
        if(array[i] % 2 == 0) 
            count++;
    return count;
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateRandomArray(size);
ShowArray(newArray);

int result = CountEvenNumberInArray(newArray);
Console.Write("Количество чётных элементов в массиве: " + result); */

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/* int[] CreateRandomArray(int size, int minValue, int maxValue)
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

int SumEvenPos(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
        sum = sum + array[i];           
    return sum;
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
int result = SumEvenPos(newArray);
Console.Write("Сумма элементов массива стоящих на нечётных позициях: " + result); */

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

/* double[] CreateRandomArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(minValue + new Random().NextDouble()*(maxValue - minValue), 2); // Искуственно сокращаю вещественное число до 2-х знаков после запятой
    }
    return array;
} */

/* double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
     
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double DiffMaxMin(double[] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
    }
    diff = max - min;
    return diff;
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
double result = Math.Round(DiffMaxMin(newArray), 2); // Искуственно сокращаю вещественное число до 2-х знаков после запятой
Console.Write("Разница между максимальным и минимальным элементами массива: " + result); */


double[] CreateRandomDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for(int i = 0; i < size; i++)
        array[i] = Math.Round((new Random().Next(minValue, maxValue) + new Random().NextDouble()), 2);
     
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double GetDiff(double[] array)
{
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] < min) min = array[i];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
        if(array[i] > max) max = array[i];
    double result = Math.Round(max - min, 2);
    return result;
}

Console.WriteLine("Введите количество элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально-возможное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально-возможное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomDoubleArray(length, min, max);
ShowArray(array);

Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + GetDiff(array));