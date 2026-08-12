public class Solution {
    public string MinWindow(string s, string t) {
        Dictionary<char, int> target = new Dictionary<char, int>();
        foreach (char c in t) {
            if (!target.ContainsKey(c)) {
                target[c] = 1;
            } else {
                target[c]++;
            }
        }
        int need = target.Count;

        Dictionary<char, int> fr = new Dictionary<char, int>();
        int left = 0;
        int have = 0;
        int bestStart=0;
        int bestLength=100001;
        for (int right = 0; right < s.Length; right++) {
            fr[s[right]] = fr.ContainsKey(s[right]) ? fr[s[right]] + 1 : 1;
            if (target.ContainsKey(s[right]) && fr[s[right]] == target[s[right]]) {
                have++;
            }
            while(need == have) {
                int windowSize=right-left+1;
                if(windowSize<bestLength){
                    bestLength=windowSize;
                    bestStart=left;
                }
                char removed=s[left];
                fr[removed]--;
                left++;

                if(target.ContainsKey(removed) && fr[removed]<target[removed]){
                    have--;
                }
            }
        }
        return bestLength==100001 ? "":s.Substring(bestStart,bestLength);
    }
}
