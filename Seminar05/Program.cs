// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

/* int[] CreateRandomArray()
{
    int[] array = new int[12];

    for (int i = 0; i < 12; i++)
    {
        array[i] = new Random().Next(-9, 10);
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

int GetSumOfNegative(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++) 
        if(array[i] < 0) 
            sum += array[i];
    return sum;
}

Console.Clear();
int[] newArray = CreateRandomArray();
ShowArray(newArray);

int result = GetSumOfNegative(newArray);
Console.Write("Сумма отрицательных элементов указанного массива: " + result); */

// Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

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

int[] ChangeElementArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = - array[i];           
    return array;
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
newArray = ChangeElementArray(newArray);
ShowArray(newArray); */


// Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

bool FindNumberInArray(int[] array, int num)
{
    bool res = false; // можно не задавать, лучше для оптимизации
    for(int i = 0; i < array.Length; i++)
        if(array[i] == num) // return true; лучше для оптимизации
            res = true;  //  
    return res; // return false; лучше для оптимизации
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение отрезка в котором ищем элементы: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
bool result = FindNumberInArray(newArray, number);
if(result == true) Console.WriteLine("Введенное число присутсвует в массиве");
else Console.WriteLine("Введенное число НЕ присутсвует в массиве"); */

// Задача 4. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

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

int FindNumberElementArray(int[] array, int minSegment, int maxSegment)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i] >= minSegment && array[i] <= maxSegment)
            count++;
    return count;
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение отрезка в котором ищем элементы: ");
int minSegment = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение отрезка в котором ищем элементы: ");
int maxSegment = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
int result = FindNumberElementArray(newArray, minSegment, maxSegment);
Console.WriteLine("Количество элементов массива в заданном отрезке: " + result); */

