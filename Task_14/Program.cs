/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

System.Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
int num = Convert.ToInt32(Console.ReadLine());

//Первый вариант решения

if (num < 8)
{
    if (num > 5)
    {
        System.Console.WriteLine("Юху!!! Выходной!!!");
    }
    else
    {
        System.Console.WriteLine("Будний день:( Работяги, на завод!!!");
    }
}
else
{
    System.Console.WriteLine("Вы живете в мире где больше 7 дней в неделе? Видимо, Вы всегда успеваете до дедлайна! Может еще и в сутках не 24 часа? (*Завидует*)");
}

//Второй вариант решения

switch (num){
    case 1:
    {
        Console.WriteLine("Понедельник - Будний день:( Работяги, на завод!!!"); 
        break; 
    }
    case 2:
    {
        Console.WriteLine("Вторник - Будний день:( Работяги, на завод!!!"); 
        break; 
    }    
    case 3:
    {
        Console.WriteLine("Среда - Будний день:( Работяги, на завод!!!"); 
        break; 
    }
    case 4:
    {
        Console.WriteLine("Четверг - Будний день:( Работяги, на завод!!!"); 
        break; 
    }
    case 5:
    {
        Console.WriteLine("Пятница - Будний день:( Работяги, на завод!!!"); 
        break; 
    }
    case 6:
    {
        Console.WriteLine("Суббота - Юху!!! Выходной!!!"); 
        break; 
    }
    case 7:
    {
        Console.WriteLine("Воскресенье - Юху!!! Выходной!!!"); 
        break; 
    }
    default:
    {
        Console.WriteLine("Вы живете в мире где больше 7 дней в неделе? Видимо, Вы всегда успеваете до дедлайна! Может еще и в сутках не 24 часа? (*Завидует*)"); 
        break; 
    }
}