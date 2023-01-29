Console.Clear();
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/* double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    double minValue = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    double maxValue = Convert.ToDouble(Console.ReadLine());


    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = Math.Round(minValue + new Random().NextDouble()*(maxValue - minValue), 2); // Искуственно сокращаю вещественное число до 2-х знаков после запятой

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray); */


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/* int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement(int[,] array, int row, int column)
{
    int element = array[row,column];
    Console.WriteLine($"Элемента массива с индексом {row},{column}: {element}");
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Input the row index number: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the column index number: ");
int columnIndex = Convert.ToInt32(Console.ReadLine());

if(rowIndex < myArray.GetLength(0) && columnIndex < myArray.GetLength(1))
    FindElement(myArray, rowIndex, columnIndex);
else
    Console.WriteLine("Элемента массива с таким индексом нет"); */

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

/* int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] AverageColumns(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            arr[j] += array[i,j];

        arr[j] = arr[j] / array.GetLength(0);
    }
    return arr;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

double[] result = new double[myArray.GetLength(1)];
result = AverageColumns(myArray);
ShowArray(result); */