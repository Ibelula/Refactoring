
public class Max
{
	public double value;
	public bool open;

	public Max(double value, bool open)
	{
		this.value = value;
		this.open = open;
	}
	public bool greaterOrEquals(double value)
	{
		if (this.open)
			return this.value > value;
		return this.value >= value;
	}
}
