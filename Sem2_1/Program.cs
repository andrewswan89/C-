int TNum(int num)
{
    int sc = 0;
    sc = (num % 100 - num % 10) / 10;
    return sc;
}
Console.WriteLine("Введите трехзначное число");
string isn=Console.ReadLine();
int isns = int.Parse(isn);
Console.WriteLine($"Вторая цифра этого числа {TNum(isns)}");