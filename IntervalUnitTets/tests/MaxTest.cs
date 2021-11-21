using Xunit;
using FluentAssertions;
using Moq;
public class MaxTest
{
    [Test]
    public void givenMaxOpenedwhenGreaterWithLessValueThenTrue()
    {
        Assert.True(new Max(4, true).greaterOrEquals(0.0));
    }

    [Test]
    public void givenMaxOpenedwhenGreaterWithGreaterValueThenFalse()
    {
        Assert.False(new Max(4, true).greaterOrEquals(5.0));
    }

    [Test]
    public void givenMaxOpenedwhenGreaterWithEqualValueThenFalse()
    {
        Assert.False(new Max(4, true).greaterOrEquals(4));
    }

    [Test]
  public void givenMaxClosedwhenGreaterWithLessValueThenTrue()
    {
        Assert.True(new Max(4, false).greaterOrEquals(0.0));
    }

    [Test]
    public void givenMaxClosedwhenGreaterWithGreaterValueThenFalse()
    {
        Assert.False(new Max(4, false).greaterOrEquals(5.0));
    }

    [Test]
    public void givenMaxClosedwhenGreaterWithEqualValueThenFalse()
    {
        Assert.True(new Max(4, false).greaterOrEquals(4));
    }
}