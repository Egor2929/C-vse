// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index =0;
    while(index < count)

    {
        Console.WriteLine(arr[index] + " ");
        index++;
    }
}
void FillArray(int[] array)
{
    int length = array.Length;
    int index=0;
    while (index < length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
}

int[] array = new int[8];
int count = array.Length;

FillArray(array);
PrintArray(array);

//Вариант с доски

// int[] arr = new int[8];
// Random rand = new Random():

// for (int i= 0;i<array.Length;i++)
// {
//     array[i]=rand.Next(0,2);
// }
// Console.WriteLine(string.Join(", ", arr));