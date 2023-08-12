using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Run(500);
    }

    static void Run(int speed = 300)
    {
        Console.WriteLine("This is running with Speed "+ speed +" PHR");
    }
}
