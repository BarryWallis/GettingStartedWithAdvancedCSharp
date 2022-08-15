namespace ExpressionBodiedMethodDemo;

internal class Test
{
    public static int CalculateSum1(int a, int b)
    {
        int sum = a + b;
        return sum;
    }

    public static int CalculateSum2(int a, int b) => a + b;
}
