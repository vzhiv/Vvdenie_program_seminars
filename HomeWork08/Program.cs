Console.Clear();
// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void SortRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int maxPos = j; 
            for(int lCol = j + 1; lCol < array.GetLength(1); lCol++)
            {
                if(array[i,lCol] > array[i,maxPos]) maxPos = lCol;
            }
            int temp = array[i,j];
            array[i,j] = array[i,maxPos];
            array[i,maxPos] = temp;
        }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
SortRows(newArray);
Show2dArray(newArray); */

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumRow(int[,] array)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            tempSum +=array[i,j];  

        if(i == 0) minSum = tempSum;
        else if(minSum > tempSum) 
        {
            minSum = tempSum;
            row = i;
        }

    }
    return row;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int result = MinSumRow(newArray);
Console.Write($"Minimal sum in row: {result+1}"); */

// Задача 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiArrays(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    
    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(1); j++)
            for(int r = 0; r < array1.GetLength(1); r++)
                result[i,j] += array1[i, r] * array2[r, j];

    return result;
}
Console.WriteLine("Input data for first array");
int[,] Array1 = CreateRandom2dArray();
Console.WriteLine("Input data for second array");
int[,] Array2 = CreateRandom2dArray();
Show2dArray(Array1);
Show2dArray(Array2);

if(Array1.GetLength(1) == Array2.GetLength(0))
{
    int[,] result = MultiArrays(Array1, Array2);
    Show2dArray(result);
}
else Console.Write("Матрицы невозможно перемножить"); */


// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/* int[,,] CreateRandom3dArray(int rows, int columns,int depth)
{

    int[,,] array = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < depth; k++)
            {
                int temp = new Random().Next(10, 100);
                if(CheckRepeat(array, temp) == true)
                    array[i,j,k] = temp;
                else
                {
                    k--;
                }
            }

    return array;
}

bool CheckRepeat(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if(array[i,j,k] == number) return false;

    return true;
}

void Show3dArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                Console.Write($"{array[i,j,k]} ({i}, {j}, {k}) ");

            Console.WriteLine();
        }
    Console.WriteLine();
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of depth: ");
int depth = Convert.ToInt32(Console.ReadLine());

if(rows*columns*depth <= 90)
{
    int[,,] myArray = CreateRandom3dArray(rows, columns, depth);
    Show3dArray(myArray);
}
else
    Console.Write("Введенный массив не получиться полностью заполнить не повторяющимися 2-х значными числами"); */

// Задача 5. Напишите программу, которая заполнит спирально массив 4 на 4.

/* int[,] CreateSpiral2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    int num = 1;
    int minRow = 0;
    int maxRow = rows - 1;
    int minCol = 0;
    int maxCol = columns - 1;
    while (num <= array.Length)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            array[minCol, i] = num;
            num++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            array[i, maxCol] = num;
            num++;
        }
        maxCol--;
        for (int i = maxCol; i >= minCol; i--)
        {
            array[maxRow, i] = num;
            num++;
        }
        maxRow--;
        for (int i = maxRow; i >= minRow; i--)
        {
            array[i, minCol] = num;
            num++;
        }
        minCol++;
    }
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateSpiral2dArray();
Show2dArray(newArray); */
