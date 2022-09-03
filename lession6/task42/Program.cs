// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// double A= Math.Log2
// Console.WriteLine((int)Math.Log2(число)+1);

void ReversArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];

    }
}
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
int size = (int)Math.Log2(a) + 1;


int[] array = new int[size];
Random rand = new Random();


for (int i = 0; i < array.Length; i++)
{
    array[i] = a  %2;
    a=a/2;
}

ReversArray(array);

Console.WriteLine(string.Join(",", array));