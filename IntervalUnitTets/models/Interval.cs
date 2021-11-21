public class Interval
{
	private double min;
	private Max max;

	public Interval(bool minOpen, double min, Max max)
	{
		Test.Assert(min <= max.value);
		this.min = min;
		this.max = max;
	}

	public bool include(double value)
	{
		return this.min <= value && this.max.isWithin(value);
	}
}
