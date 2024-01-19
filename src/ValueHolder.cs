public struct ValueHolder<T>
    where T : class?
{
    private readonly T value;

    public ValueHolder(T value)
    {
        this.value = value;
    }

    public void TryExecute(Action<T> action)
    {
        if (value != default)
        {
            action(value);
        }
    }
}
