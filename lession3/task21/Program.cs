// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.ReadLine().Split().Select(Convert.ToInt32).ToArray();


// √(xb - xa)2 + (yb - ya)2 

Console.WriteLine("Введите точку XA :");
double XA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку YA :");
double YA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку XB :");
double XB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку YB :");
double YB = Convert.ToDouble(Console.ReadLine());


double res = Math.Sqrt(Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2));

Console.WriteLine($"{res:f2}");









// double res1 = Math.Pow(XB - XA);
// Console.WriteLine(XA);

// double res2 = Math.Pow(YB - YA);
// Console.WriteLine(res2);

