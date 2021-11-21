using Xunit;
using FluentAssertions;
using Moq;
public class MaxTest
{
    [Test]
    public void givenMaxOpenedwhenGreaterWithLessValueThenTrue()
    {
        Assert.True(new Max(4).isOnLeft(0.0));
    }

    [Test]
    public void givenMaxOpenedwhenGreaterWithGreaterValueThenFalse()
    {
        Assert.False(new Max(4).isOnLeft(5.0));
    }

    [Test]
    public void givenMaxOpenedwhenGreaterWithEqualValueThenFalse()
    {
        Assert.False(new Max(4).isOnLeft(4));
    }
}