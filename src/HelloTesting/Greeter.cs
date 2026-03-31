namespace HelloTesting;

public sealed class Greeter
{
    public string SayHello(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return "Hello, world!";
        }

        return $"Hello, {name.Trim()}!";
    }
}
