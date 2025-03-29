using static System.Console;
WriteLine(Calculator.AddValues(2, 3));        // เรียกใช้ AddValues(int, int)
WriteLine(Calculator.AddValues(2.0f, 3.0f));  // เรียกใช้ AddValues(float, float)
WriteLine(Calculator.AddValues(2L, 3L));      // เรียกใช้ AddValues(long, long)

public static class Calculator
{
    public static int AddValues(int a, int b)
    {
        WriteLine("Calculated by method: public static int AddValues(int a, int b)");
        return a + b;
    }

    public static float AddValues(float f, float g)
    {
        WriteLine("Calculated by method: public static float AddValues(float f, float g)");
        return f + g;
    }

    public static long AddValues(long h, long i)
    {
        WriteLine("Calculated by method: public static long AddValues(long h, long i)");
        return h + i;
    }
}
