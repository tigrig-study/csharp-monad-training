var valueHolder1 = new ValueHolder<string?>("abc");
var result1 = ""; // ← ここで定義するのがビミョー
valueHolder1.TryExecute(value => result1 = value + "def");

var valueHolder2 = new ValueHolder<string?>(result1);
var result2 = ""; // ← ここで定義するのがビミョー
valueHolder2.TryExecute(value => result2 = value + "ghi");

Console.WriteLine(result2);
