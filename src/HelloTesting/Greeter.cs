namespace HelloTesting;

public sealed class Greeter
{
    public string SayHello(string name)
    {
        var normalizedName = string.IsNullOrWhiteSpace(name)
            ? "world"
            : name.Trim();

        return $"Hello, {normalizedName}!";
    }
}
