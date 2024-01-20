public struct ValueHolder<T>
    where T : class?
{
    private readonly T value;

    public ValueHolder(T value)
    {
        this.value = value;
    }

    public ValueHolder<T> TryExecute(Func<T, T> func)
    {
        if (value != default)
        {
            return new ValueHolder<T>(func(value));
        }

        return this; // new ValueHolder(value) と同義
    }

    public void TryExecute(Action<T> action)
    {
        if (value != default)
        {
            action(value);
        }
    }
}

public static class ValueHolder
{
    public static ValueHolder<T> Some<T>(T value)
        where T : class
    {
        return new ValueHolder<T>(value);
    }

    public static ValueHolder<T?> None<T>()
        where T : class
    {
        return new ValueHolder<T?>(null);
    }
}
