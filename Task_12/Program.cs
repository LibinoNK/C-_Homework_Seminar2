/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

//Первый вариант решения

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99)
{
    while (num > 999)
    {
        num = num/10;
    }
    System.Console.WriteLine(num%10);
}
else
{
    System.Console.WriteLine("Некорректное число, введите число с минимум 3мя цифрами");
}

//Второй вариант решения

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.Length >= 3)
{
    System.Console.WriteLine(number[2]);
}
else
{
    System.Console.WriteLine("Неверное число, введите трехзначное число");
}