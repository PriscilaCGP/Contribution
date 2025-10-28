namespace Contribution;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Contribuiçãoo");
        Thread.Sleep(1000);
        Console.WriteLine(":D");
        Thread.Sleep(1000);
        Console.Write("Saindo");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(900);
            Console.Write(".");
        }
    }
}