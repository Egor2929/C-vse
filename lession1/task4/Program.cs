// Вывести вссе числа от -Ндо Н

Console.WriteLine("Введите число N :");
int N = Convert.ToInt32(Console.ReadLine());

 int counter = -N; //бер левый диапазон
 while (counter<= N)
 {
Console.Write(counter + " ");
counter++;
 }