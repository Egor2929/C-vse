// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Доп. условие для 51 задачи: сделать суммирование в один цикл. Матрица может быть прямоугольный

int[,] FillMatrix(int rowsCount, int columsCount, int lestRange = 1, int rightRange = 10)
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

int sum=0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    if(i==j)
        {
            sum+= matrix[i, j];
        }
        Console.WriteLine();
}
PrintMatrix(matrix);
Console.WriteLine();
