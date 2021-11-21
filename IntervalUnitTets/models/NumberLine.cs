public class NumberLine
{

    public static double VALUE = 4.4;
    public static double DEVIATION = 0.1;

    public static double less(double value)
    {
        return value - NumberLine.DEVIATION;
    }

    public static double equals(double value)
    {
        return value;
    }

    public static double greater(double value)
    {
        return value + NumberLine.DEVIATION;
    }
}