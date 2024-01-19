var dict = new Dictionary<int, int> { { 123, 111 }, { 456, 222 } };

dict.TryExecute(789, Console.WriteLine);

var dict2 = new Dictionary<string, int> { { "123", 111 }, { "456", 222 } };

dict2.TryExecute("456", Console.WriteLine);

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
