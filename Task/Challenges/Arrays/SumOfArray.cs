namespace Task.Challenges.Arrays;

public static class SumOfArray
{
    public static int SumOf(this int[] array)
    {
        int sum = 0;

        foreach (var item in array)
        { 
            sum += item;
        }
        return sum;
    }
}
