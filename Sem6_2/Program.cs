void pointcoordinates(){
    Console.Write("b1: ");
    int b1 = int.Parse(Console.ReadLine());
    Console.Write("c1: ");
    int k1 = int.Parse(Console.ReadLine());
    Console.Write("b2: ");
    int b2 = int.Parse(Console.ReadLine());
    Console.Write("c2: ");
    int k2 = int.Parse(Console.ReadLine());
    int x = (b2 - b1)/(k1 - k2);
    int y1 = k1 * x + b1;
    int y2 = k2 * x + b2;
    Console.WriteLine($"Точка пересечения: y1 = {y1}, y2 = {y2}");
}

pointcoordinates();