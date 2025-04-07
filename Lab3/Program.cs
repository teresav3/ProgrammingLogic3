namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        //Part 1
        int a = 10, b = 5, c = 15;
        Console.WriteLine(a > b);
        Console.WriteLine(a < c);
        Console.WriteLine(a > b + c);
        Console.WriteLine(a > b && a < c);
        Console.WriteLine(a > b || a < c);

    }
}
