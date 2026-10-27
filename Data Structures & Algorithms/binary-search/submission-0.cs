public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;

        while(low <= high)
        {
            int mid = (low + high) / 2;
            int guess = nums[mid];

            if(guess == target)
                return mid;
            else if(guess > target)
                high = mid - 1;
            else
                low = mid + 1;
        }
        return -1;
    }
}
