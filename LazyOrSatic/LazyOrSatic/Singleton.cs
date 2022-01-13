namespace LazyOrSatic;

public sealed class Singleton
{
    private Singleton() { }

    private static readonly Lazy<Singleton> Lazy = new(() => new Singleton());

    public static Singleton Instance => Lazy.Value;

    public string Format(string template, params object[] args)
    {
        return string.Format(template, args);
    }
}