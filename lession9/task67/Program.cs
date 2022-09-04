// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.WriteLine("Vedie chislo N");//число строкс
int N = Convert.ToInt32(Console.ReadLine());
int sum=PrintNumbersToN(N);
Console.WriteLine(sum);


int PrintNumbersToN(int N)
{
    
    int count = 0;
    if (N <= 0) return 0;
    count = N % 10;
    N = N / 10;
    return count+PrintNumbersToN(N);
}



// int res=SumNCount(N);
// Console.WriteLine(res);


// int SumNCount(int N);
// {
//     if (N < 1) return 0;
//     return1 + SumNCount(N - 1);
// }