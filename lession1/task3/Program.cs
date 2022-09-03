// //Условие задачи ,чтобы введеное пользователем чило показывало какому числу соответсвует день недели,если число не соответствует задонному диапозону ,то пользователь видет предупреждение о тома что такого дня недели не существет 



// Console.WriteLine("Введите номер дня недели :");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 7 || number < 1)
// {
//     Console.WriteLine("Такого дня недели не существует ");
// }
// if (number == 1)
// {
//     Console.WriteLine("Понедельник ");
// }
// if (number == 2)
// {
//     Console.WriteLine("Вторник ");
// }
// if (number == 3)
// {
//     Console.WriteLine("Среда ");
// }
// if (number == 4)
// {
//     Console.WriteLine("Четверг ");
// }
// if (number == 5)
// {
//     Console.WriteLine("Пятница ");
// }
// if (number == 6)
// {
//     Console.WriteLine("Суббота ");
// }
// if (number == 7)
// {
//     Console.WriteLine("Воскресенье ");
// }

Console.WriteLine("Введите номер дня недели :");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Пондельнк");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница ");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресенье");
        break;
    default:
        Console.WriteLine("НЕт такого дня");
        break;
}