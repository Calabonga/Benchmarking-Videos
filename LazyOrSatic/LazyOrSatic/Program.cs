// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using LazyOrSatic;

BenchmarkRunner.Run<TestBench>();

[MemoryDiagnoser]
public class TestBench
{
    private string Template => "This is just a string for temlate formatting {0} Lorem {1} ipsum dolor sit amet, consectetuer adipiscing elit." +
                               " Donec sed pede. Etiam ante purus, consectetuer id,bibendum fermentum, accumsan sed, nunc. Vestibulum dignissim," +
                               " leo vel aliquam dignissim, nibh ligula cursus tortor,in vulputate neque lorem eu sem. Morbi nibh nulla, tempus ac," +
                               " varius sed, porta sit amet, nulla. Proin laoreet.Phasellus quis tortor eu augue rutrum posuere. Suspendisse quis " +
                               "dolor vitae nisl fermentum rutrum. Etiam mi mauris,imperdiet sed, volutpat ac, ornare in, urna. Sed laoreet turpis nec sem." +
                               " Nam consectetuer, tellus rhoncus laciniaeuismod, augue tellus consectetuer sem, a molestie tellus nisi a dolor. Nunc" +
                               " tempus ante sit amet arcu. Lorem ipsumdolor sit amet, consectetuer adipiscing elit. Aliquam vitae quam. Integer consectetuer " +
                               "lacinia ligula. Praesentadipiscing viverra libero. {2}";
    private DateTime Date => new DateTime(2022,01,13);

    private int Total => 222;

    [Benchmark]
    public string GetDataFromStatic()
    {
        return StaticClass.Format(Template, Date, Total, "Ok");
    }
    
    [Benchmark]
    public string GetDataFromSingleton()
    {
        return Singleton.Instance.Format(Template, Date, Total, "Ok");
    }
}