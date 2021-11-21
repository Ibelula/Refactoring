public class Point
{
    public static double DEVIATION = 0.1;
    public double value;

    Point(double value)
    {
        this.value = value;
    }

    double getLess()
    {
        return this.value - Point.DEVIATION;
    }

    double getEquals()
    {
        return this.value;
    }

    double getGreater()
    {
        return this.value + Point.DEVIATION;
    }
}