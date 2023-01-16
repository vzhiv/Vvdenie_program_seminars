// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

/* int GetExp(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a;
    } 
    return result;
}

Console.Clear();
Console.Write("Ввидите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите степень в которую возвести введеное число: ");
int b = Convert.ToInt32(Console.ReadLine());

int  result = GetExp(a, b);

Console.WriteLine($"Число {a} в степени {b}: " + result); */

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

/* int SumNumbers(int num)
{
    int result = 0;
    while (num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }

    return result;
}

Console.Clear();
Console.Write("Ввидите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int  result = SumNumbers(number);

Console.WriteLine("Сумма цифр введенного числа составляет: " + result); */


// Задача 3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.


/* int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива и нажмите Enter");
        array[i] = Convert.ToInt32(Console.ReadLine());    
    }
    return array;
}

void TypeArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "; ");
    }
    Console.WriteLine();
}

Console.Clear();
Console.Write("Введите число элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(m);
TypeArray(newArray); */