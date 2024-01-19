var valueHolder = new ValueHolder<string?>("123");
valueHolder.TryExecute(Console.WriteLine);

var valueHolder2 = new ValueHolder<string?>(null);
valueHolder2.TryExecute(Console.WriteLine);
