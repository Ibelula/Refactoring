﻿using Xunit;
using FluentAssertions;
using Moq;
public class IntervalTest
{
    [Test]
    public void givenIntervalwhenIncludeWithIncludedValueThenTrue()
    {
        Assert.True(new Interval(-1.7, 5555.0).include(0.0));
    }
}