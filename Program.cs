var dict = new Dictionary<int, int> { { 123, 111 }, { 456, 222 } };

if (dict.TryGetValue(789, out var r))
{
    Console.WriteLine(r);
}
