
public class Max
{
	public double value;
	protected bool open;

	public Max(double value)
	{
		this.value = value;
	}

	public virtual bool isWithin(double value)
	{
		return this.value > value;
	}
}
