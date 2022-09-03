// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите точку X :");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку Y :");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Точка находится в первой координатной плоскости ");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится во ворой координатной плоскости ");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine("Точка находится в третей координатной плоскости ");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Точка находится в четвертой координатной плоскости ");

}
else 
{
    Console.WriteLine("Мы не можем определить координтую четверть ");
}