public class IncludedMax : Max
{
  public IncludedMax(int value) : base(value) 
    { 
    }
    public bool isOnLeft(double value)
    {
        return this.value >= value;
    }
}
