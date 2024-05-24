namespace DXKuma.Backend.Utils;

public class Possible<T1, T2>
{
    private readonly object? _obj;

    public Possible(T1 obj)
    {
        _obj = obj;
    }

    public Possible(T2 obj)
    {
        _obj = obj;
    }

    private T1? GetType1()
    {
        return (T1?)_obj;
    }

    private T2? GetType2()
    {
        return (T2?)_obj;
    }

    public static implicit operator Possible<T1, T2>(T1 t)
    {
        return new(t);
    }

    public static implicit operator Possible<T1, T2>(T2 t)
    {
        return new(t);
    }

    public static implicit operator T1?(Possible<T1, T2> t)
    {
        return t.GetType1();
    }

    public static implicit operator T2?(Possible<T1, T2> t)
    {
        return t.GetType2();
    }
}