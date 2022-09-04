// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Vedie chislo A");//число строкс
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Vedie chislo B");//число строкс
int B = Convert.ToInt32(Console.ReadLine());

int SqrAtoB(int  A,int B)
{
    if(B==0) return 1;
    else return SqrAtoB(A,B-1)*A;
}
int sum = SqrAtoB(A,B);
Console.WriteLine(sum);






// int PowerRec(int A,int B)
// {
//     return B==0 ? 1: PowerRec(A,B-1)*A;
//     //if(B==0) return1;
//     // else return PowerRec(A,B-1)*A;
// }
// int sum = PowerRec(A,B);
// Console.WriteLine(sum);