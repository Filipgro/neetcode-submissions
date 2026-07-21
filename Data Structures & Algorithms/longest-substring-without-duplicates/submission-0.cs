public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left=0;
        int right=0;
        int longest=0;
        HashSet<char> set = new HashSet<char>();
        while(right<s.Length){
            if(!set.Contains(s[right])){
                set.Add(s[right]);
                right++;
            }
            else
            {
                set.Remove(s[left]);
                left++;
            }
            longest = Math.Max(longest, right - left);
        }
        return longest;
    }
}
