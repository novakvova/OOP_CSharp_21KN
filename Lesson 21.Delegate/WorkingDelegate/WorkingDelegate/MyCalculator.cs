namespace WorkingDelegate;

public delegate int MySuperDelegate(int x, int y);

public class MyCalculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Minus(int a, int b)
    {
        return a - b;
    }
}
