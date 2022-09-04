// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




Console.WriteLine("Vedie chislo");//число строкс
int N = Convert.ToInt32(Console.ReadLine());

PrintNumbersToN(N);

void PrintNumbersToN(int N)
{
    if(N<1) return;
    PrintNumbersToN(N-1);
    Console.Write(N+" ");
}



// int[,] FillMatrix(int rowsCount, int columsCount, int lestRange = 0, int rightRange = 10)
// {
//     int[,] matrix = new int[rowsCount, columsCount];

//     Random rand = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(lestRange, rightRange + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Vedie chislo");//число строкс
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Vedie chislo");//число столбцов 
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrix(m, n);
// PrintMatrix(matrix);
// Console.WriteLine();

// for (int j = 0; j < matrix.GetLength(1); j++)
// {
//     int temp = matrix[0, j];
//     matrix[0, j] = matrix[matrix.GetLength(0)-1, j];
//     matrix[matrix.GetLength(0) - 1, j] = temp;
// }
// PrintMatrix(matrix);
