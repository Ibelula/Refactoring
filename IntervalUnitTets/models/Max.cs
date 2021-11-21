public class Max
{
    public double value;
    public Max(double value)
    {
        this.value = value;
    }

    public virtual bool isWithin(double value)
    {
        return this.value > value;
    }

    public override int GetHashCode()
    {
        const int prime = 31;
        int result = 1;        
        return result;
    }

    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        Max other = (Max)obj;
        return true;
    }

    public override string ToString()
    {
        return this.value + ")";
    }
}
