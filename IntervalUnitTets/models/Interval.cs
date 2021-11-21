public class Interval
{
	private double min;
	private double max;
	private bool maxOpen;

	public Interval(bool minOpen, double min, bool maxOpen, double max)
	{
		Test.Assert(min <= max);
		this.min = min;
		this.max = max;
		this.maxOpen = maxOpen;
	}

	public bool include(double value)
	{
		if (this.maxOpen)
			return this.min <= value && value < this.max;
		return this.min <= value && value <= this.max;		
	}
}
