public class ClosedMax : Max
{

    public ClosedMax(double value) : base(value)
    {
    }

    public override bool isWithin(double value)
    {
        return base.isWithin(value) || this.value == value;
    }
}