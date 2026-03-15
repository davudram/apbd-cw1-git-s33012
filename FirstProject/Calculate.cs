namespace FirstProject;

public class Calculate
{
    public static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0) return 0;
    
        int sum = 0;
        foreach (int val in values)
        {
            sum += val;
        }
        return (double)sum / values.Length;
    }

    public static double CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0) return 0;

        int max = values[0];
        foreach(int val in values)
        {
            if (val > max)
                max = val;
        }

        return max;
    }

    public static double CalculateMin(int[] values)
    {
        if (values == null || values.Length == 0) return 0;

        int min = values[0];
        foreach (int val in values)
        {
            if (val < min)
                min = val;
        }
        return min;
    }
}