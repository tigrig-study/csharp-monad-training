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
