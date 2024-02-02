namespace HelloWorld;

public interface IHelloGrain : IGrainWithStringKey
{
    ValueTask<string> SayHello(string greeting);
    ValueTask<int> GiveNum(int num);
}
