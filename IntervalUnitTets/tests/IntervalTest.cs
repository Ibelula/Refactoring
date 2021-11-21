using Xunit;
using FluentAssertions;
using Moq;
public class IntervalTest
{
    [Test]
    public void givenMaxwhenGreaterWithLessValueThenTrue()
    {
        Assert.True(new Interval(true, -1.7, new Max(5555.0, true)).include(0.0));
    }

    [Test]
    public void givenIntervalwhenIncludeWithNotIncludedValueThenFalse()
    {
        Assert.False(new Interval(true, -1.7, new Max(5555.0, true)).include(9000.0));
    }

    [Test]
    public void givenIntervalwhenIncludeWithLimitValueThenFalse()
    {
        Assert.False(new Interval(true, -1.7, new Max(5555.0, true)).include(5555.0));
    }
}