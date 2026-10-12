public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char,int> dic = new Dictionary<char,int>();
        int index = 1;
        foreach(char c in order){
            if(!dic.ContainsKey(c)) dic[c] = index;
            index++;
        }
        for(int i = 0; i < words.Length-1; i++){
            string word1 = words[i];
            string word2 = words[i+1];
            
            for(int j = 0; j < word1.Length; j++){
                if(j == word2.Length) return false;
                if(word1[j] != word2[j]){
                    if(dic[word2[j]] < dic[word1[j]]) return false;
                    break;
                }
            }
        }
        return true;
    }
}