using Xunit;
using FluentAssertions;
using Moq;
public class IntervalTest
{
    [Test]
  public void givenIntervalwhenIncludeWithIncludedValueThenTrue()
    {
        Assert.True(new Interval(true, -1.7, new Max(5555.0)).include(0.0));
    }

    [Test]
    public void givenIntervalwhenIncludeWithNotIncludedValueThenFalse()
    {
        Assert.False(new Interval(true, -1.7, new Max(5555.0)).include(9000.0));
    }

    [Test]
    public void givenIntervalwhenIncludeWithLimitValueThenFalse()
    {
        Assert.False(new Interval(true, -1.7, new Max(5555.0)).include(5555.0));
    }
}