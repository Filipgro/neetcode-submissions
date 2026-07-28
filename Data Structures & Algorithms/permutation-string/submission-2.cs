public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var freq = new Dictionary<char,int>();
        foreach(char c in s1){
            if(!freq.ContainsKey(c)){
                freq[c]=1;
            }else{
                freq[c]++;
            }
        }
        var freqWindow=new Dictionary<char,int>();

        int left=0;
        int right=0;
        while(right<=s2.Length-1){
            if(!freqWindow.ContainsKey(s2[right])){
                freqWindow[s2[right]]=1;
            }
            else
            {
                freqWindow[s2[right]]++;
            }

             if(right - left + 1 > s1.Length){
                freqWindow[s2[left]]--;
                if(freqWindow[s2[left]]==0){
                    freqWindow.Remove(s2[left]);
                }
                left++;
            }
            if(right - left + 1 == s1.Length){
                if (freq.OrderBy(x => x.Key).SequenceEqual(freqWindow.OrderBy(x => x.Key)))
                {
                    return true;
                }
            }
            right++;
        }
        return false;
    }
}
