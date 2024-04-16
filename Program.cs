// Реализуйте операторы неявного приведения из long,int,byt в Bits.
using lesson_2;

internal class Program
{
    public static void Main()
    {
        Bits<byte> bits = 5;
        Console.WriteLine(bits.Value.GetType());
        Console.WriteLine(bits);
        
        Bits<int> bits2 = 7;
        Console.WriteLine(bits2.Value.GetType());
        Console.WriteLine(bits2);
        
        Bits<long> bits3 = 9;
        Console.WriteLine(bits3.Value.GetType());
        Console.WriteLine(bits3);

        bits3 = 11;
        Console.WriteLine(bits3.Value.GetType());
        Console.WriteLine(bits3);
    }
}