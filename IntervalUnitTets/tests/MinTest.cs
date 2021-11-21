using Xunit;
using FluentAssertions;
using Moq;
public class MinTest
{

    protected Min min;

    //@BeforeEach
    public void before()
    {
        this.min = new Min(NumberLine.VALUE);
    }

    [Test]
    public void givenMinWhenIsWithinWithLessValueThenTrue()
    {
        Assert.False(this.min.isWithin(NumberLine.less(NumberLine.VALUE)));
    }

    [Test]
    public virtual void givenMinWhenIsWithinWithEqualsValue()
    {
        Assert.False(this.min.isWithin(NumberLine.equals(NumberLine.VALUE)));
    }

    [Test]
    public void givenMinWhenIsWithinWithGreaterValueThenTrue()
    {
        Assert.True(this.min.isWithin(NumberLine.greater(NumberLine.VALUE)));
    }
}