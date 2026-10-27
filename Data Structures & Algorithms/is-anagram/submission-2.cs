public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] count = new int[26];
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        foreach (var c in count)
        {
            if (c != 0)
                return false;
        }
        return true;
    }
}
