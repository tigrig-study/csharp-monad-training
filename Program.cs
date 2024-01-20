var option1 = Option.Return("abc");
var option2 = option1.Bind(value =>
{
    var optionInner = Option.Return("def");
    return optionInner.Bind(valueInner => Option.Return(value + valueInner));
});
