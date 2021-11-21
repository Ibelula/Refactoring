using Xunit;
using FluentAssertions;
using Moq;
public class MaxTest
{
    [Test]
    public void givenIntervalwhenIncludeWithIncludedValueThenTrue()
    {
        Assert.True(new Max(true, 4).greater(0.0));
    }
}