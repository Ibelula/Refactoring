public class Min
{
	protected double value;

	public Min(double value)
	{
		this.value = value;
	}

	public bool isWithin(double value)
	{
		return this.value < value;
	}
}