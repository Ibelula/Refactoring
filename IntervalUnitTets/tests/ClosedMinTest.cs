using Xunit;
using Moq;
public class ClosedMinTest : MinTest {

  protected override Min createMin() {
    return new ClosedMin(this.point.getEquals());
  }

  [Test]
  public override void givenMinWhenIsWithinWithEqualsValue(){
    Assert.True(this.min.isWithin(this.point.getEquals()));
  }
  
}
