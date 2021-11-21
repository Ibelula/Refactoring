using Xunit;
using Moq;

public class MinTest
{

    protected Min min;
    protected Point point;

    [BeforeEach]
    public void before()
    {
        this.point = new Point(4.4);
        this.min = this.createMin();
    }

    protected virtual Min createMin()
    {
        return new Min(this.point.getEquals());
    }

    [Test]
    public void givenMinWhenIsWithinWithLessValueThenTrue()
    {
        Assert.False(this.min.isWithin(this.point.getLess()));
    }

    [Test]
    public virtual void givenMinWhenIsWithinWithEqualsValue()
    {
        Assert.False(this.min.isWithin(this.point.getEquals()));
    }

    [Test]
    public void givenMinWhenIsWithinWithGreaterValueThenTrue()
    {
        Assert.True(this.min.isWithin(this.point.getGreater()));
    }

}