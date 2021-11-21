using Xunit;
using FluentAssertions;
using Moq;
public class MaxTest
{

    protected static double VALUE = 4.4;
    private static double DEVIATION = 0.1;

    public Max createMax(double value)
    {
        return new Max(value);
    }

    [Test]
    public void givenMaxWhenIsWithinWithLessValueThenTrue()
    {
        Assert.True(createMax(VALUE).isWithin(less(VALUE)));
    }

    [Test]
    public virtual void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.False(createMax(VALUE).isWithin(equals(VALUE)));
    }

    [Test]
    public void givenMaxWhenIsWithinWithGreaterValueThenTrue()
    {
        Assert.False(createMax(VALUE).isWithin(greater(VALUE)));
    }

    protected double less(double value)
    {
        return value - MaxTest.DEVIATION;
    }

    protected double equals(double value)
    {
        return value;
    }

    protected double greater(double value)
    {
        return value + MaxTest.DEVIATION;
    }

}