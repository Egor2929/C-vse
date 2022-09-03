// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вводим массив через консоль

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine($"Введите  массив [{index}]:");
        int N = Convert.ToInt32(Console.ReadLine());
        array[index] = N;
        index++;
    }
}

void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)


        
        {
            Console.Write(arr[index] + " ");
            index++;
        }
}

    int[] array = new int[8];
    int count = array.Length;

    FillArray(array);
    PrintArray(array);


