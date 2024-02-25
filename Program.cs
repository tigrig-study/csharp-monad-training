// Option.Bind
var option11 = Option.Return(new int[] { 1 });
var option12 = option11.Bind(value1 =>
{
    var option21 = Option.Return(new int[] { 2 });
    return option21.Bind(value2 =>
    {
        var option31 = Option.Return(new int[] { 3 });
        return option31.Bind(value3 => Option.Return("" + value1[0] + value2[0] + value3[0]));
    });
});

option12.Match(Console.WriteLine);

// LINQ.SelectMany
var list11 = new int[] { 1, 2 };
var list12 = list11.SelectMany(value1 =>
{
    var list21 = new int[] { 2 };
    return list21.SelectMany(value2 =>
    {
        var list31 = new int[] { 3 };
        return list31.SelectMany(value3 => new string[] { "" + value1 + value2 + value3 });
    });
});

Console.WriteLine(string.Join(", ", list12));
