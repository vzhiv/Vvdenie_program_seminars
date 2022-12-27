// Задача 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

/*
 void GetDiapazone(int quadrant)
 {
    if(quadrant == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quadrant == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quadrant == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quadrant == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Wrong input");
 }

Console.Clear();

Console.Write("Enter number quadrant: ");
int QuadNum = Convert.ToInt32(Console.ReadLine());

GetDiapazone(QuadNum);
*/

// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*
double GetCoordinate(double x, double y)
{
   int quadrant = -1;
   if(x > 0 && y > 0) quadrant = 1;
   else if(x < 0 && y > 0) quadrant = 2;
   else if(x < 0 && y < 0) quadrant = 3;
   else if(x > 0 && y < 0) quadrant = 4;
   
   return quadrant;
}

Console.Clear();

Console.Write("Enter coordinate x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y: ");
double y = Convert.ToDouble(Console.ReadLine());

double QuadNum = GetCoordinate(x,y);

if(QuadNum > 0) Console.WriteLine("Dot in: " + QuadNum);
else Console.WriteLine("Wrong data");
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт квадраты чисел от 1 до N.

/*
void QuadNumber(double number)
{
   int index = 1;
   while(index <= number)
   {
      double quadnum = Math.Pow(index,2);
      Console.Write(quadnum + " ");
      index++;   
   }
   
}

Console.Clear();
Console.Write("Enter number: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.Write("Квадраты числа от 1 до N ");
QuadNumber(number);
*/


// Задача 4. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

void GetDistance(double x1, double y1, double x2, double y2)
{
   double distance = Math.Sqrt((Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)));
   Console.Write("Distance between dot1 and dot2 : " + distance);   
}


Console.Clear();

Console.Write("Enter coordinate x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

GetDistance(x1, y1, x2, y2);







