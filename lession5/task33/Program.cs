// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите массив а ");
int A = Convert.ToInt32(Console.ReadLine());

int[] array = new int[A];
Random rand = new Random();
int i;
bool res = false;

for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);

    if (array[i] == A)
    {
        res = true;
    
    }

}
Console.WriteLine(string.Join(", ", array)); 

if (res == true)
{
    Console.WriteLine("da");
}
else
{
    Console.WriteLine("neta");
}