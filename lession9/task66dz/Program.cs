// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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
    int sum = SumMoN(N , M);
    Console.WriteLine(sum);
}

int SumMoN(int N, int M)
{
    if (N < M) return 0;
    int sum = SumMoN(N - 1, M);
    return sum += N;
}