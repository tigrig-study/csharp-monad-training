var valueHolder1 = new ValueHolder<string?>("abc");
var result1 = valueHolder1.TryExecute(value => value + "def");

var valueHolder2 = new ValueHolder<string?>(result1);
var result2 = valueHolder2.TryExecute(value => value + "ghi");

Console.WriteLine(result2);

var valueHolder3 = new ValueHolder<string?>(null);
var result3 = valueHolder3.TryExecute(value => value + "ghi");
if (result3 is null)
{
    Console.WriteLine("is null!");
}
else
{
    Console.WriteLine(result3);
}
