// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Ввелите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 10000 && N < 100000)
{
    int numb1 = N.ToString()[0] ;
    int numb2 = N.ToString()[1] ;
    int numb3 = N.ToString()[2] ;
    int numb4= N.ToString()[3] ;
    int numb5= N.ToString()[4] ;
    if (numb1 == numb5 && numb2 == numb4)
    {
        Console.WriteLine($"{N} палиндром");
    }
    else
    {
        Console.WriteLine($"{N} не  палиндром");
    }
}
else
{
    Console.WriteLine("Введено неверное число");
}

