using PrivateProxy;

namespace private_proxy_unsafe_accessor;

public class PrivateAccess
{
    private int _counter;

    private void Increment() => _counter++;

    private void Show()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("O valor do nosso contador é ");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{_counter}.");
    }

    private static ref int GetInstanceCounter(ref PrivateAccess privateObjects) => ref privateObjects._counter;
}

[GeneratePrivateProxy(typeof(PrivateAccess))]
public partial class PrivateAccessProxy;
