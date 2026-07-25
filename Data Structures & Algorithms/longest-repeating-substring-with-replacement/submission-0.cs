public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        int left = 0;
        int right = 0;
        int maxFreq = 0;
        int longest = 0;
        var freq = new Dictionary<char, int>();
        while (right < s.Length)
        {
            if(!freq.ContainsKey(s[right])){
                freq[s[right]]=1;
            }else{
                freq[s[right]]++;
            }
            maxFreq = Math.Max(maxFreq, freq[s[right]]);
            while((right-left+1)-maxFreq>k){
                freq[s[left]]--;
                if(freq[s[left]]==0){
                    freq.Remove(s[left]);
                }
                left++;
            }
            longest=Math.Max(longest,right-left+1);
            right++;
        }
        return longest;
    }
}
