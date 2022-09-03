// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Vedie chislo");
// int a =

int[,] FillMatrix(int rowsCount, int columsCount, int lestRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rand.Next(lestRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,]matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write(matrix[i, j]);
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Vedie chislo");//число строкс
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vedie chislo");//число столбцов 
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m,n);
PrintMatrix(matrix);