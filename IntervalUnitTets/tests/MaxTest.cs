using Xunit;
using FluentAssertions;
using Moq;
public class MaxTest
{
    protected Max max;

    //@BeforeEach
    public void before()
    {
        this.max = new Max(NumberLine.VALUE);
    }

    [Test]
    public void givenMaxWhenIsWithinWithLessValueThenTrue()
    {
        Assert.True(this.max.isWithin(NumberLine.less(NumberLine.VALUE)));
    }

    [Test]
    public virtual void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.False(this.max.isWithin(NumberLine.equals(NumberLine.VALUE)));
    }

    [Test]
    public void givenMaxWhenIsWithinWithGreaterValueThenTrue()
    {
        Assert.False(this.max.isWithin(NumberLine.greater(NumberLine.VALUE)));
    }
}