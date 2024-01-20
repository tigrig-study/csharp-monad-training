var valueHolder1 = ValueHolder.Some("abc");
valueHolder1.TryExecute(Console.WriteLine); // 実行される

var valueHolder2 = ValueHolder.None<string>();
valueHolder2.TryExecute(Console.WriteLine); // 実行されない
