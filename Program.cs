var option1 = Option.Some("abc");
var option2 = option1.TryExecute(value =>
{
    var optionInner = Option.Some("def");
    return optionInner.TryExecute(valueInner => Option.Some(value + valueInner));
});
