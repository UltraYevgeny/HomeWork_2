/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
void SecondDigit(int number)
{
    int second_digit = (number % 100)/10;
    Console.Write("Second digit is: " + second_digit);
}

Console.Write("Enter 3-digit number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number >= 100 && user_number <= 999)
{
    SecondDigit(user_number);
}
else
    Console.WriteLine("ERROR, your number is not 3-digits");
*/

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
void ThirdDigit(int number)
{
    int countZero = 1;
    int number3 = number;
    bool three = false;
    while (three == false)
    {
        if (number3 < 1000)
        {
            Console.WriteLine(number3 % 10);
            three = true;
        }
        else 
        {
            countZero = countZero * 10;
            number3 = number/countZero;
        }
    }
}

Console.Write("Enter 3-digit number minimum: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number < 100)
{
    Console.Write("Number less then 3-digit!");
}
else ThirdDigit(user_number);
*/

/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


void WhatDay (int numberDay)
{
    if (numberDay > 0 && numberDay < 6)
    {Console.WriteLine ("No");}
    if (numberDay > 5 && numberDay < 8)
    {Console.WriteLine ("Yes");}
}
Console.Write("Enter number day of week: ");
int dayOfWeek = Convert.ToInt32(Console.ReadLine());

if (dayOfWeek > 0 && dayOfWeek < 8)
{WhatDay(dayOfWeek);}
else
{Console.WriteLine("This is NOT a day of week!");}
