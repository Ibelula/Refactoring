public class ClosedMin : Min
{

    public ClosedMin(double value) : base(value) { }

    public bool isWithin(double value)
    {
        return base.isWithin(value) || this.value == value;
    }

}