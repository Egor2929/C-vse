// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число : ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >= 100 & a < 1000)
{
    int digit1 = a / 10;
    int digit2 = digit1 % 10;
    Console.WriteLine($"Вторая цифра {digit2} ");
}
else
{
Console.WriteLine("Число имеет больше трех символов");
}





