using Xunit;
using FluentAssertions;
using Moq;
public class IntervalTest
{
    [Test]
    public void givenIntervaOpenOpenlwhenIncludeWithIncludedValueThenTrue()
    {
        Assert.True(new Interval(true, -1.7, new Max(5555.0)).include(0.0));
        Assert.False(new Interval(true, -1.7, new Max(5555.0)).include(9000.0));
        Assert.False(new Interval(true, -1.7, new Max(5555.0)).include(5555.0));
        Assert.True(new Interval(true, -1.7, new ClosedMax(5555.0)).include(0.0));
        Assert.False(new Interval(true, -1.7, new ClosedMax(5555.0)).include(9000.0));
        Assert.True(new Interval(true, -1.7, new ClosedMax(5555.0)).include(5555.0));
    }
}