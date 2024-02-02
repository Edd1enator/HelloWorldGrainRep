namespace HelloWorld;

public sealed class HelloGrain : Grain, IHelloGrain
{
    public ValueTask<string> SayHello(string greeting) =>
        ValueTask.FromResult($"Hola, {greeting}!");

    public ValueTask<int> GiveNum(int greeting) =>
        ValueTask.FromResult(greeting + 10);
}
