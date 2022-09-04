// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Vedie chislo N");//число строкс
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vedie chislo M");//число строкс
int M = Convert.ToInt32(Console.ReadLine());

if (M > N)
{
    Console.WriteLine("Число М не может быть больше Н");//число строкс
}
else
{
    PrintNumbersToN(N, M);
}
PrintNumbersToN(N, M);

void PrintNumbersToN(int N, int M)
{
    if (N < M) return;
    PrintNumbersToN(N - 1, M);
    Console.Write(N + " ");
}