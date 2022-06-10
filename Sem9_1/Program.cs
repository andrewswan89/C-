// / Задача 1. Домашнее задание
// Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void ValueSet(int n, int m)
{
    if (n > m) return;
    if (n % 2 == 0) Console.Write($"{n}, ");
    ValueSet(n + 1, m);
}

ValueSet(4, 8);
Console.WriteLine();

