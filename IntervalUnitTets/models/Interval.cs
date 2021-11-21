public class Interval
{
	private double min;
	private double max;

	public Interval(double min, double max)
	{
		Test.Assert(min <= max);
		this.min = min;
		this.max = max;
	}

	public bool include(double value)
	{
		return this.min <= value && value <= this.max;		
	}
}
