using Xunit;
using FluentAssertions;
using Moq;
public class IntervalTest
{
    [Test]
    public void givenIntervalOpenClosewhenIncludeWithIncludedValueThenTrue()
    {
        Assert.True(new Interval(true, -1.7, new ClosedMax(5555.0)).include(0.0));
    }

    [Test]
    public void givenIntervalOpenClosewhenIncludeWithNotIncludedValueThenFalse()
    {
        Assert.False(new Interval(true, -1.7, new ClosedMax(5555.0)).include(9000.0));
    }

    [Test]
    public void givenIntervalOpenClosewhenIncludeWithLimitValueThenFalse()
    {
        Assert.True(new Interval(true, -1.7, new ClosedMax(5555.0)).include(5555.0));
    }
}