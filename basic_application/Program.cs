public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        
        if (name != null) {
            Console.WriteLine($"My name is {name}.");
        }
        else
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
