// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array = new int[5];
Random rand = new Random();
int i =0;


for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
    
    if (array[i]%2 ==0)
    {
        
        i++;
        
    }
}
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(i);