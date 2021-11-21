public class ClosedMin : Min
{
    public ClosedMin(double value) : base(value) { }

    public override bool isWithin(double value)
    {
        return base.isWithin(value) || this.value == value;
    }
    public override string ToString()
    {
        return "[" + this.value;
    }
}