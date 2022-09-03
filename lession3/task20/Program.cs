// Задача 20

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// √(xb - xa)2 + (yb - ya)2  + (zb - za)2

Console.WriteLine("Введите точку XA :");
double XA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку YA :");
double YA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку XB :");
double XB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку YB :");
double YB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку ZA :");
double ZA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку ZB :");
double ZB = Convert.ToDouble(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(XB - XA, 2) + Math.Pow(YB - YA, 2) + Math.Pow(ZB - ZA, 2));

Console.WriteLine($"{res:f2}");
