public class ClosedMax : Max
{

    public ClosedMax(double value) : base(value)
    {
    }

    public override bool isWithin(double value)
    {
        return this.value >= value;
    }
}