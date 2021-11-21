using Xunit;
using Moq;

public class IntervalTest
{

    private Point left = new Point(-2.2);
    private Point right = new Point(4.4);
    private IntervalBuilder intervalBuilder;

    [BeforeEach]
    public void before()
    {
        this.left = new Point(-2.2);
        this.right = new Point(4.4);
        this.intervalBuilder = new IntervalBuilder();
    }

    [Test]
    public void givenIntervaOpenOpenlwhenIncludeWithIncludedValueThenTrue()
    {
        Interval interval = this.intervalBuilder.open(left.getEquals()).open(right.getEquals()).build();
        Assert.False(interval.include(left.getLess()));
        Assert.False(interval.include(left.getEquals()));
        Assert.True(interval.include(left.getGreater()));
        Assert.True(interval.include(right.getLess()));
        Assert.False(interval.include(right.getEquals()));
        Assert.False(interval.include(right.getGreater()));
    }

    [Test]
    public void givenIntervaOpenOpenlwhenInc3ludeWithIncludedValueThenTrue()
    {
        Interval interval = this.intervalBuilder.closed(left.getEquals()).open(right.getEquals()).build();
        Assert.False(interval.include(left.getLess()));
        Assert.True(interval.include(left.getEquals()));
        Assert.True(interval.include(left.getGreater()));

        Assert.True(interval.include(right.getLess()));
        Assert.False(interval.include(right.getEquals()));
        Assert.False(interval.include(right.getGreater()));
    }

    [Test]
    public void givenIntervaOpenOpenlwhenIncludeWit3hIncludedValueThenTrue()
    {
        Interval interval = this.intervalBuilder.open(left.getEquals()).closed(right.getEquals()).build();
        Assert.False(interval.include(left.getLess()));
        Assert.False(interval.include(left.getEquals()));
        Assert.True(interval.include(left.getGreater()));

        Assert.True(interval.include(right.getLess()));
        Assert.True(interval.include(right.getEquals()));
        Assert.False(interval.include(right.getGreater()));
    }

    [Test]
    public void givenIntervaOpenOpenlwhenIncludeWithInclude5dValueThenTrue()
    {
        Interval interval = this.intervalBuilder.closed(left.getEquals()).closed(right.getEquals()).build();
        Assert.False(interval.include(left.getLess()));
        Assert.True(interval.include(left.getEquals()));
        Assert.True(interval.include(left.getGreater()));

        Assert.True(interval.include(right.getLess()));
        Assert.True(interval.include(right.getEquals()));
        Assert.False(interval.include(right.getGreater()));
    }

}