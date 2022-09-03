// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] FillMatrix(int rowsCount, int columsCount, int lestRange = 0, int rightRange = 10)
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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Vedie chislo");//число строкс
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vedie chislo");//число столбцов 
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int[,] reversMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        reversMatrix[i,j]=matrix[j,i];
    }
    
}
PrintMatrix(reversMatrix);