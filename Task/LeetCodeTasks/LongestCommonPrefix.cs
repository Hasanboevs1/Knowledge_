namespace Task.Tasks;

public class LongestCommonPrefix
{
    public bool IsAnyDigitDuplicated(int[] digits)
    {
        var values = new List<int>();
        foreach (var digit in digits)
        {
            if(values.Contains(digit))
                return true;
            values.Add(digit);
        }
        return false;
    }
}
