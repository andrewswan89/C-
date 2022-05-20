int TNum(int num)
{
    int sc = 0;
    sc = num % 10;
    return sc;
}
Console.WriteLine("Введите число");
string isn=Console.ReadLine();
int ist = int.Parse(isn);
if(ist<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(TNum(ist));  
}