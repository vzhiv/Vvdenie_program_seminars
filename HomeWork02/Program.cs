// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
int SecondNumber(int num)
{
    int des = num / 10 % 10;
     
    return des;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number / 1000 == 0 && number / 100 > 0)
{
    int result = SecondNumber(number);
    Console.WriteLine("Вторая цифра введенного числа : " + result);
}
else
{
    Console.WriteLine("Введенное значение не является трехзначным");
}
*/


// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*
int ThirdNumber(int num)
{
    int ed = 0;
    while(num / 1000 > 0)
    {
        num = num / 10;
    }    
    ed = num % 10;
    return ed;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number / 100 > 0)
{
    int result = ThirdNumber(number);
    Console.WriteLine("Третья цифра введенного числа : " + result);
}
else
{
    Console.WriteLine("В введенном числе нет третьей цифры");
}
*/


// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*
bool Weekend(int num)
{
    if(num == 6 || num == 7)
    {
        return true;    
    } 
    else
    {
        return false;
    }
}


Console.Write("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>=1 && number<=7)
{
    if (Weekend(number))
    {
        Console.WriteLine("Введенный день недели является выходным");
    }
    else
    {
        Console.WriteLine("Введенный день недели НЕ является выходным");
    }

}
else
{
    Console.WriteLine("Введенное значение не является днем недели");
}

*/