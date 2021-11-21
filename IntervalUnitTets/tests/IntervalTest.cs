using Xunit;
using FluentAssertions;
using Moq;
public class IntervalTest
{
    [Test]
    public void givenIntervaOpenOpenlwhenIncludeWithIncludedValueThenTrue()
    {
        Assert.True(new Interval(true, -1.7, new Max(NumberLine.VALUE)).include(NumberLine.less(NumberLine.VALUE)));
        Assert.False(new Interval(true, -1.7, new Max(NumberLine.VALUE)).include(NumberLine.equals(NumberLine.VALUE)));
        Assert.False(new Interval(true, -1.7, new Max(NumberLine.VALUE)).include(NumberLine.greater(NumberLine.VALUE)));
        Assert.True(new Interval(true, -1.7, new ClosedMax(NumberLine.VALUE)).include(NumberLine.less(NumberLine.VALUE)));
        Assert.True(new Interval(true, -1.7, new ClosedMax(NumberLine.VALUE)).include(NumberLine.equals(NumberLine.VALUE)));
        Assert.False(new Interval(true, -1.7, new ClosedMax(NumberLine.VALUE)).include(NumberLine.greater(NumberLine.VALUE)));
    }
}