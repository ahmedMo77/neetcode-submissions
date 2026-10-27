public class Solution {
    public bool hasDuplicate(int[] nums) {
        var n = nums.Length;
        var dist = nums.Distinct().ToArray();
        if (n == dist.Length)
            return false;

        return true;
    }
}
