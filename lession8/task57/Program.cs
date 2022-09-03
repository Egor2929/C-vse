﻿// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза
// В нашей исходной матрице встречаются элементы от 0 до 9

int[,] FillMatrix(int rowsCount, int columsCount, int lestRange = 0, int rightRange = 9)
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
int[] array = new int[10];
Console.WriteLine("Vedie chislo");//число строкс
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Vedie chislo");//число столбцов 
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        array[matrix[i, j]] = array[matrix[i, j]] + 1;
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Колличество {i}={array[i]}");
}


// Console.WriteLine("Vedie chislo");//число строкс
// int m = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Vedie chislo");//число столбцов 
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = FillMatrix(m, n);
// PrintMatrix(matrix);
// Console.WriteLine();
