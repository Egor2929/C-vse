// Задача 18: Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти  :");
int numb1 = Convert.ToInt32(Console.ReadLine());


if (numb1 == 1)
{
    Console.WriteLine("X > 0 , Y > 0 ");
}
else if (numb1 == 2)
{
    Console.WriteLine("X < 0 , Y > 0 ");
}
else if (numb1 == 3)
{
    Console.WriteLine("X < 0 ,  Y < 0 ");
}
else if (numb1 == 4)
{
    Console.WriteLine("X > 0 ,  Y < 0 ");

}
else
{
    Console.WriteLine("Мы не можем определить координтую четверть ");
}