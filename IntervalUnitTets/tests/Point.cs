public class Point
{
    public static double DEVIATION = 0.1;
    public double value;

    public Point(double value)
    {
        this.value = value;
    }

    public double getLess()
    {
        return this.value - Point.DEVIATION;
    }

    public double getEquals()
    {
        return this.value;
    }

    public double getGreater()
    {
        return this.value + Point.DEVIATION;
    }
}