// Задача 1. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*
int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}

bool IsEven(int num)
{
    if(num % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int randNumber = new Random().Next(100,1000);
Console.WriteLine("Current random three-digit number is " + randNumber);

int newNumber = CutNumber(randNumber);
Console.WriteLine("New version of number is " + newNumber);

*/

// Задача 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

/*
int MaxNumber(int number)
{
    int des = number / 10;
    int ed = number % 10;

    if(des > ed)
    {
        return des;
    }
    else
    {
        return ed;
    }
}

int randNumber = new Random().Next(10,100);
Console.WriteLine("Current random two-digit number is " + randNumber);

int MNumber = MaxNumber(randNumber);
Console.WriteLine("Max number is " + MNumber);

*/


// Задача 3. Напишите программу, которая будет принимать на вход два числа и определять, является ли второе число кратным первому.

/*
bool MultipleNumber(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return true;    
    } 
    else
    {
        return false;
    }
}


Console.Write("Input a first number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = MultipleNumber(number1, number2);

Console.WriteLine("Second number " + result);

*/




// Задача 4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


bool SquareNumber(int num1, int num2)
{
    if(num1*num1 == num2 || num2*num2 == num1)
    {
        return true;    
    } 
    else
    {
        return false;
    }
}


Console.Write("Input a first number ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool result = SquareNumber(number1, number2);

Console.WriteLine(result);

