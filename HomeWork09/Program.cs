Console.Clear();
// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

/* void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num - 1);
    
}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNums(number); */

// Задача 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* int GetSum(int num1, int num2)
{
    if(num1 < num2) return GetSum(num1, num2 - 1) + num2;
    else if(num2 < num1) return GetSum(num1 - 1, num2) + num1;
    else return num1;
}

Console.Write("Input a first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSum(number1, number2)); */

// Задача 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

/* double GetAckerman(double num1, double num2)
{
    if(num1 == 0) return num2 + 1;
    else if(num2 == 0) return GetAckerman(num1 - 1, 1);
    else return GetAckerman(num1 - 1, GetAckerman(num1, num2 - 1));
}

Console.Write("Input a first number: ");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a second number: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if(number1 >= 0 && number2 >= 0) Console.WriteLine(GetAckerman(number1, number2));
else Console.WriteLine("Введены не верные данные"); */