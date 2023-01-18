/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

//Первый вариант решения

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int result = (num%100)/10;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Неверное число, введите трехзначное число");
}

//Второй вариант решения

System.Console.WriteLine("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.Length == 3)
{
    System.Console.WriteLine(number[1]);
}
else
{
    System.Console.WriteLine("Неверное число, введите трехзначное число");
}