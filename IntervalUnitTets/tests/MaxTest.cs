using Xunit;
using Moq;

public class MaxTest
{

    protected Max max;
    protected Point point;

    [BeforeEach]
    public void before()
    {
        this.point = new Point(4.4);
        this.max = this.createMax();
    }

    protected virtual Max createMax()
    {
        return new Max(this.point.getEquals());
    }

    [Test]
    public void givenMaxWhenIsWithinWithLessValueThenTrue()
    {
        Assert.True(this.max.isWithin(this.point.getLess()));
    }

    [Test]
    public virtual void givenMaxWhenIsWithinWithEqualsValue()
    {
        Assert.False(this.max.isWithin(this.point.getEquals()));
    }

    [Test]
    public void givenMaxWhenIsWithinWithGreaterValueThenTrue()
    {
        Assert.False(this.max.isWithin(this.point.getGreater()));
    }

}
