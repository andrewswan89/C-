// // Задача 2. Домашнее задание
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int ValueSet(int n, int m)
{
    if (n > m) return 0;
    return ValueSet(n + 1, m) + n;

}

Console.WriteLine(ValueSet(1, 15));

