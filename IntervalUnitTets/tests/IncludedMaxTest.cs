using Xunit;
using FluentAssertions;
using Moq;
public class IncludedMaxTest : MaxTest
{    
    public Max createMax(double value)
    {
        return new ClosedMax(NumberLine.VALUE);
    }

    [Test]
    public override void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.True(this.max.isWithin(NumberLine.equals(NumberLine.VALUE)));
    }
}
