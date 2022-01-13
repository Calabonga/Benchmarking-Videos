namespace LazyOrSatic;

public static class StaticClass
{
    public static string Format(string template, params object[] args)
    {
        return string.Format(template, args);
    }
}