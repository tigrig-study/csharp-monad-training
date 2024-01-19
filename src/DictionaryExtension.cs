public static class DictionaryExtension
{
    public static void TryExecute<TKey, TValue>(
        this Dictionary<TKey, TValue> dict,
        TKey key,
        Action<TValue> action
    )
        where TKey : notnull
    {
        if (dict.TryGetValue(key, out var r))
        {
            action(r);
        }
    }
}
