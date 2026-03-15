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
}