// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


                                                //Variant1
Console.WriteLine("Введите число ");
int A = Convert.ToInt32(Console.ReadLine());

int count = 0;

for (count = 0; A > 0; count++)
{
    A = A / 10;
}

                                                //Variant 2
// while (A > 0)
// {
//     A = A / 10;
//     count++;
// }

Console.WriteLine(count);
