namespace HelloTesting;

internal static class Program
{
    private static void Main(string[] args)
    {
        var greeter = new Greeter();
        var name = args.Length > 0 ? string.Join(" ", args) : "world";

        Console.WriteLine(greeter.SayHello(name));
    }
}
