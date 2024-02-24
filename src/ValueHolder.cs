public class Option<T>
    where T : class?
{
    private readonly T? value;

    public Option(T? value)
    {
        this.value = value;
    }

    public Option<T> Bind(Func<T, Option<T>> func)
    {
        if (value != default)
        {
            return func(value);
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

public static class Option
{
    public static Option<T> Return<T>(T value)
        where T : class?
    {
        return new Option<T>(value);
    }

    public static Option<T> None<T>()
        where T : class?
    {
        return new Option<T>(null);
    }
}
