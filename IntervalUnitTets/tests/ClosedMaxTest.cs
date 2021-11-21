using Xunit;
using Moq;
public class ClosedMaxTest : MaxTest
{
    protected override Max createMax()
    {
        return new ClosedMax(this.point.getEquals());
    }
    public override void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.True(this.max.isWithin(this.point.getEquals()));
    }
}
