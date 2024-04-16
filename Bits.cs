namespace lesson_2;

public class Bits<T>
{
    private Bits(T b)
    {
        if (typeof(T).ToString() == "System.Int32" || 
            typeof(T).ToString() == "System.Byte" ||
            typeof(T).ToString() == "System.Int64")
        {
            Value = b;
        }
    }

    public T Value { get; }

    //
    public static implicit operator Bits<T>(T b)
    {
        return new Bits<T>(b);
    }

    public override string ToString()
    {
        return Value.ToString();
    }
}