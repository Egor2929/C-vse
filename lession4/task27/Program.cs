// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число  ");
int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int res = 0;
int numb;


while (A > 10)
{
    numb = A % 10;
    sum = sum + numb;
    A = A / 10;
}
if (A<10)
{
    res = sum + A;
}

Console.WriteLine(res);







// int i;
// int sum = 0;
// int res = 0 ;
// for (sum = 0; A > 0; i++)
// {
//     sum = A % 10;
//     A = A + sum;
// }

// Console.WriteLine(A);