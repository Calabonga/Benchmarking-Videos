using BenchmarkDotNet.Attributes;

namespace BenchmarkingCharMerging.Testing;

[MemoryDiagnoser]
public class CharTesting
{
    private readonly char[] _charArray = { 'П', 'и', 'ш', 'и', 'т', 'е', ' ', 'п', 'р', 'а', 'в', 'и', 'л', 'ь', 'н', 'ы', 'й', ' ', 'к', 'о', 'д' };

    [Benchmark]
    public string MethodWithConstructor()
    {
        return new string(_charArray);
    }

    [Benchmark]
    public string MethodWithConcat()
    {
        return string.Concat(_charArray);
    }

    [Benchmark]
    public string MethodWithJoin()
    {
        return string.Join("", _charArray);
    }
}