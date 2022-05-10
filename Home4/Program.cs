// Напишите программу, которая на вход
//принимает число (N), а на выходе показывает все чётные
//числа от 1 до N.

Console.Write("Введите число: ");
string number = Console.ReadLine();
int num = int.Parse(number);

int count = 1;

while(count <= num)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
        Console.Write(", ");
    }
    count++;
}
Console.WriteLine();
