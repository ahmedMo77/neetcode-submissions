public class Solution {
    public bool hasDuplicate(int[] nums) {
        var sortedNums = nums.Order().ToArray();
        var n = nums.Length;
        for (int i = 1; i < n; i++)
        {
            if (sortedNums[i] == sortedNums[i - 1])
                return true;
        }
        return false;
    }
}
