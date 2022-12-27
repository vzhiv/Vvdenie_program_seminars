// Задача 1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*
Console.Clear();
bool CheckPalindrom(int num)
{
    int naoborot = 0;
    int shortnum = num;
    while(shortnum / 10 != 0 || shortnum % 10 > 0)
    {
        naoborot = naoborot * 10 + shortnum % 10;
        shortnum = shortnum / 10;
        Console.Write(shortnum + " " + naoborot + " ");        
    }    
    if(num == naoborot) return true; 
    else return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = CheckPalindrom(number);

if(result == true) Console.WriteLine("Введенное число является палиндромом");
else Console.WriteLine("Введенное число НЕ является палиндромом");
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
void GetDistance(double x1, double y1, double z1, double x2, double y2, double z2)
{
   double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
   Console.Write("Distance between dot1 and dot2 : " + distance);   
}


Console.Clear();

Console.Write("Enter coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

GetDistance(x1, y1, z1, x2, y2, z2);
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*
void CubeNumber(double number)
{
   int count = 1;
   while(count <= number)
   {
      double cubenum = Math.Pow(count,3);
      Console.Write(cubenum + " ");
      count++;   
   }
   
}

Console.Clear();
Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());

if(number > 0)
{
    Console.Write("Кубическая степень числа от 1 до введенного ");
    CubeNumber(number);
}
else Console.Write("Введенные данные не корректны");
*/