public struct ValueHolder<T>
    where T : class?
{
    private readonly T value;

    public ValueHolder(T value)
    {
        this.value = value;
    }

    public T TryExecute(Func<T, T> func)
    {
        if (value != default)
        {
            return func(value);
        }

        return value;
    }
}
