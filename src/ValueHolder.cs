public class Option<T>
    where T : class?
{
    private readonly T? value;

    public Option(T? value)
    {
        this.value = value;
    }

    public Option<U> Bind<U>(Func<T, Option<U>> func)
        where U : class?
    {
        if (value != default(T))
        {
            return func(value);
        }

        return Option.None<U>();
    }

    public void Match(Action<T> action)
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
