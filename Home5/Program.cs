Console.Write("Enter number: ");
string number = Console.ReadLine();
int num = int.Parse(number);

if(num < 0) num = -num;
Console.WriteLine(num);