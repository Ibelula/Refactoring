using Xunit;
using FluentAssertions;
using Moq;
public class MaxTest
{
    private static double VALUE;
    protected Max max;

    //@BeforeEach
    public void before()
    {
        this.max = new Max(NumberLine.VALUE);
    }

    [Test]
    public void givenMaxWhenIsWithinWithLessValueThenTrue()
    {
        Assert.True(this.max.isWithin(NumberLine.less(VALUE)));
    }

    [Test]
    public virtual void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.False(this.max.isWithin(NumberLine.equals(VALUE)));
    }

    [Test]
    public void givenMaxWhenIsWithinWithGreaterValueThenTrue()
    {
        Assert.False(this.max.isWithin(NumberLine.greater(VALUE)));
    }
}