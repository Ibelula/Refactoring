using Xunit;
using FluentAssertions;
using Moq;
public class IncludedMaxTest : MaxTest
{
    private static double VALUE;
    public Max createMax(double value)
    {
        return new ClosedMax(VALUE);
    }

    [Test]
    public override void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.True(this.max.isWithin(NumberLine.equals(VALUE)));
    }
}
