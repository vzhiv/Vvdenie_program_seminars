Console.Clear();
// Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/* void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5); */

// Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/* int GetSumOfDigits(int num)
{
    if(num != 0) return GetSumOfDigits(num / 10) + num % 10;
    else return 0;
}

Console.WriteLine(GetSumOfDigits(1234)); */

// f(1234) -> 4 + f(123)
// f(123) -> 3 + f(12)
// f(12) -> 2 + f(1)
// f(1) -> 1 + 0
// f(0) -> 0

// Задача 3. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/* void ShowNums(int m, int n)
{
    if(n > m) 
    {
        
        ShowNums(m, n - 1);
        Console.Write(n + " ");
    }    
    else if(m > n)
    {
        Console.Write(m + " ");
        ShowNums(m - 1, n);
        
    }
    else Console.Write(n + " ");
}

Console.Write("Input a first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m, n); */

// Задача 4. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double GetDegree(double num, double deg)
{
    if(deg > 0) return GetDegree(num, deg - 1) * num;
    else if(deg < 0) return 1 / (GetDegree(num, - deg - 1) * num);   // return (1/num)*GetDegree(num. degree+1); ???
    else return 1;
}

Console.Write("Input a number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a degree: ");
double degree = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDegree(number, degree));