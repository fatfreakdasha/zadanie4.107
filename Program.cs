using System;

Console.WriteLine("введите год");
int year = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер месяца");
int month = Convert.ToInt32(Console.ReadLine());
switch (month)
{
    case 1: Console.Write("месяц: январь - 31 день"); break;
    case 2:
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            Console.Write("месяц: февраль - 29 дней");
        }
        else
        {
            Console.Write("месяц: февраль - 28 дней");
        }
        break;
    case 3: Console.Write("месяц: март - 31 день"); break;
    case 4: Console.Write("месяц: апрель - 30 дней"); break;
    case 5: Console.Write("месяц: май - 31 день"); break;
    case 6: Console.Write("месяц: июнь - 30 дней"); break;
    case 7: Console.Write("месяц: июль - 31 день"); break;
    case 8: Console.Write("месяц: август - 31 день"); break;
    case 9: Console.Write("месяц: сентябрь - 30 дней"); break;
    case 10: Console.Write("месяц: октябрь - 31 день"); break;
    case 11: Console.Write("месяц: ноябрь - 30 дней"); break;
    case 12: Console.Write("месяц: декабрь - 31 день"); break;
}

















