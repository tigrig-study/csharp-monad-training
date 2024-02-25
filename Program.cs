// モナド則1: Bind に Return を渡すと、元の値がそのまま帰ってくる
var sonomama1 = Option.Return("111");
var sonomama2 = sonomama1.Bind(Option.Return);
sonomama1.Match(Console.WriteLine); // ← 111
sonomama2.Match(Console.WriteLine); // ← 111

// モナド則2: ２つの関数を続けてBindするのは、これらの関数から決まる一つの関数をBindすることに等しい
var option1 = Option.Return("abc");
var option2 = option1.Bind(value => Option.Return(value + "def"));
var option3 = option2.Bind(value => Option.Return(value + "ghi"));
option3.Match(Console.WriteLine); // ← abcdefghi

var option4 = Option.Return("abc");
var option5 = option4.Bind(value =>
    Option.Return(value + "def").Bind(value => Option.Return(value + "ghi"))
);
option5.Match(Console.WriteLine); // ← abcdefghi
