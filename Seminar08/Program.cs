Console.Clear();
// Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами a-ю и b-ю строки массива.

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

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
       row2 >= 0 && row2 < array.GetLength(0) &&
       row1 != row2)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

Console.Write("Input a number of the first row: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of the second row: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(newArray, r1, r2);
Show2dArray(newArray); */

// Задача 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

/*int[,] CreateRandom2dArray()
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

int[,] ChangeRowsColumns(int[,] array)
{
    int[,] changeArray = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            changeArray[j, i] = array[i, j];

    return changeArray;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);
int[,] result = ChangeRowsColumns(newArray);
Show2dArray(result); */


// Задача 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент. Создание нового массива, минимальный элемент первый

int[,] CreateRandom2dArray()
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

int[] FindMinElement(int[,] array)
{
    int minIndexI = 0;
    int minIndexJ = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[minIndexI, minIndexJ] > array[i, j])
            {
                minIndexI = i;
                minIndexJ = j;
            }
        }
    int[] index = {minIndexI, minIndexJ};
    return index;
}


int[,] ChangeArray(int[,] array, int[] index)
{
    int[,] changeArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int minIndexI = index[0];
    int minIndexJ = index[1];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(minIndexI > i && minIndexJ > j)
            {
                changeArray[i,j] = array[i, j];
            }
            if(minIndexI > i && minIndexJ < j)
            {
                changeArray[i ,j - 1] = array[i, j];
            }
            if(minIndexI < i && minIndexJ > j)
            {
                changeArray[i - 1,j] = array[i, j];
            }
            if(minIndexI < i && minIndexJ < j)
            {
                changeArray[i - 1,j - 1] = array[i, j];
            }
        }


    return changeArray;
}

int[,] newArray = CreateRandom2dArray();
Show2dArray(newArray);

int[] index = FindMinElement(newArray);

int[,] result = ChangeArray(newArray, index);
Show2dArray(result);

