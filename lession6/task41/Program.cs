// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа = ");
int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
int a = 0;

for (int j = 0; j < array.Length; j++)
{
    if (array[j] > 0)
    {
        a = a+1;
    }
}
Console.WriteLine(" ");
Console.WriteLine(string.Join(",", a));

