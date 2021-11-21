using System;
using Xunit;
using FluentAssertions;
using Moq;
public class ClosedMinTest : MinTest
{
  public void before()
    {
        this.min = new ClosedMin(NumberLine.VALUE);
    }

[Test]
  public override void givenMinWhenIsWithinWithEqualsValue()
{
    Assert.True(this.min.isWithin(NumberLine.equals(NumberLine.VALUE)));
}

}
