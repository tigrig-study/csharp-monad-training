var valueHolder1 = new ValueHolder<string?>("abc");
var result1 = valueHolder1.TryExecute(value => value + "def");

var result2 = result1.TryExecute(value => value + "ghi");

result2.TryExecute(Console.WriteLine);

var valueHolder3 = new ValueHolder<string?>(null);
var result3 = valueHolder3.TryExecute(value => value + "ghi");
result3.TryExecute(Console.WriteLine);
