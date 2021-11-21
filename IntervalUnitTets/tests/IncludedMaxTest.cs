using Xunit;
using FluentAssertions;
using Moq;
public class IncludedMaxTest
{
    [Test]
    public void givenMaxClosedwhenGreaterWithLessValueThenTrue()
    {
        Assert.True(new IncludedMax(4, false).greaterOrEquals(0.0));
    }

    [Test]
    public void givenMaxClosedwhenGreaterWithGreaterValueThenFalse()
    {
        Assert.False(new IncludedMax(4, false).greaterOrEquals(5.0));
    }

    [Test]
    public void givenMaxClosedwhenGreaterWithEqualValueThenFalse()
    {
        Assert.True(new IncludedMax(4, false).greaterOrEquals(4));
    }
}
