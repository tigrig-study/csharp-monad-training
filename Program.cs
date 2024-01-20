var valueHolder1 = ValueHolder.Some("abc");
var valueHolder2 = valueHolder1.TryExecute(value =>
{
    var valueHolderInner = ValueHolder.Some("def");
    return valueHolderInner.TryExecute(valueInner => ValueHolder.Some(value + valueInner));
});
