﻿ //Напишите программу, которая принимает
//    на вход число и выдаёт сумму цифр в числе.

System.Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);
int result = number;



int count1 = 0;
while (result > 0)
{
    result = result / 10;
    count1++;
}
System.Console.WriteLine();
System.Console.WriteLine($"В числе {number} {count1} цифр");
System.Console.WriteLine();
