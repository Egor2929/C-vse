// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Vedie chislo");//число строкс
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(N);

void PrintNumbersToN(int N)  // метод рекурсии на возврат числа от большего к меньшему 
{
    if(N<1) return;
    Console.Write(N+" ");
    PrintNumbersToN(N-1);
    
}

