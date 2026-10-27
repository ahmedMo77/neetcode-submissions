public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        var list = freq.Select(x => new int[] { x.Key, x.Value }).ToList();
        list.Sort((a, b) => b[1].CompareTo(a[1]));
        int[] res = new int[k];

        for (int i = 0; i < k; i++) 
        {
            res[i] = list[i][0];
        }
        return res;
    }
}
