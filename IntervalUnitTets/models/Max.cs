
public class Max
{
	private double value;
	private bool open;

	public Max(bool b, int i)
	{
		this.value = i;
		this.open = b;
	}

	public bool greater(double d)
	{
		if (this.open)
			return this.value > d;
		return this.value >= d;
	}
}
