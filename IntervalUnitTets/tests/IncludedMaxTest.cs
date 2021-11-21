using Xunit;
using FluentAssertions;
using Moq;
public class IncludedMaxTest : MaxTest
{
    public Max createMax(double value)
    {
        return new ClosedMax(value);
    }

    [Test]
    public override void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.True(createMax(VALUE).isWithin(equals(VALUE)));
    }
}
