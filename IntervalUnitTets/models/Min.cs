public class Min
{
    protected double value;
    public Min(double value)
    {
        this.value = value;
    }

    public virtual bool isWithin(double value)
    {
        return this.value < value;
    }

    public override int GetHashCode()
    {
        const int prime = 31;
        int result = 1;
        long temp;
        //temp = Double.doubleToLongBits(value);
        //result = prime * result + (int) (temp ^ (temp >>> 32));
        return result;
    }

    public bool Equals(object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        //if (getClass() != obj.getClass())
        //return false;
        Min other = (Min)obj;
        //if (Double.doubleToLongBits(value) != Double.doubleToLongBits(other.value))
        //return false;
        return true;
    }

    public override string ToString()
    {
        return "(" + this.value;
    }
}
