public class Solution {
    public int CountSeniors(string[] details) {
        int res = 0;
        for(int i = 0; i < details.Length; i++){
            if(int.Parse(details[i].Substring(11,2)) > 60) res++;
        }
        return res;
    }
}