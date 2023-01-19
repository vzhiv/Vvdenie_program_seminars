/* void ShowNum(int[] a)
{
    a[0] += 5;
    Console.WriteLine(a[0]);
}

int[] num = {5, 7, 3};

ShowNum(num);
Console.WriteLine(num[0]); */

Console.Clear();
// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

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

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++ , j--) 
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}

Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray); */


// Задача 2. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

/* bool CheckTriangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a) return true;
    else return false;
}


Console.Write("Введите длину 1-й стороны треугольника: ");
int side1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 2-й стороны треугольника: ");
int side2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 3-й стороны треугольника: ");
int side3 = Convert.ToInt32(Console.ReadLine());

bool result = CheckTriangle(side1, side2, side3);
if(result == true) Console.WriteLine("Треугольник может существовать");
else Console.WriteLine("Треугольник НЕ может существовать"); */

// Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

/* int[] Fibonacci(int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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


Console.Write("Введите какое количество чисел Фибоначчи вывести: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 1-е число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonacci(n, a, b);
ShowArray(result); */


// Задача 4. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++) 
    {
        arrayCopy[i] = array[i];
    }
    return arrayCopy;

}

Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
int[] arrayCopy = CopyArray(newArray);
ShowArray(arrayCopy); */