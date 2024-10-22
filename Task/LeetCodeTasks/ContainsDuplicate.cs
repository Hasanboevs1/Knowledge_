
namespace Task.LeetCodeTasks;

public class ContainsDuplicate
{
    public bool ContainsAnyDuplicate(int[] nums)
    {
        HashSet<int> hashset = new HashSet<int>();

        foreach(int num in nums)
        {
            if(hashset.Contains(num)) return true;
            hashset.Add(num);
        }
        return false;
    }
}
