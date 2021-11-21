public class IntervalBuilder
{
    private Min min;
    private Max max;
    private bool minConfigured;
    private bool maxConfigured;

    public IntervalBuilder()
    {
        this.minConfigured = false;
        this.maxConfigured = false;
    }

    public IntervalBuilder open(double value)
    {
        Test.Assert(!this.minConfigured || !this.maxConfigured);
        if (!this.minConfigured)
        {
            this.min = new Min(value);
            this.minConfigured = true;
        }
        else if (!this.maxConfigured)
        {
            this.max = new Max(value);
            this.maxConfigured = true;
        }
        return this;
    }

    public IntervalBuilder closed(double value)
    {
        Test.Assert(!this.minConfigured || !this.maxConfigured);
        if (!this.minConfigured)
        {
            this.min = new ClosedMin(value);
            this.minConfigured = true;
        }
        else if (!this.maxConfigured)
        {
            this.max = new ClosedMax(value);
            this.maxConfigured = true;
        }
        return this;
    }

    public Interval build()
    {
        Test.Assert(this.minConfigured && this.maxConfigured);
        return new Interval(this.min, this.max);
    }
}
