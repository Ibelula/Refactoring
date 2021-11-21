public class Interval
{
    private Min min;
    private Max max;

    public Interval(Min min, Max max)
    {
        Test.Assert(min.value <= max.value);
        this.min = min;
        this.max = max;
    }

    public bool include(double value)
    {
        return this.min.isWithin(value) && this.max.isWithin(value);
    }

    public override int GetHashCode()
    {
        const int prime = 31;
        int result = 1;
        result = prime * result + ((max == null) ? 0 : max.GetHashCode());
        result = prime * result + ((min == null) ? 0 : min.GetHashCode());
        return result;
    }
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        //if (getClass() != obj.getClass())
        //return false;
        Interval other = (Interval)obj;
        if (max == null)
        {
            if (other.max != null)
                return false;
        }
        else if (!max.Equals(other.max))
            return false;
        if (min == null)
        {
            if (other.min != null)
                return false;
        }
        else if (!min.Equals(other.min))
            return false;
        return true;
    }
    public override string ToString()
    {
        return this.min.ToString() + ", " + max.ToString();
    }
}