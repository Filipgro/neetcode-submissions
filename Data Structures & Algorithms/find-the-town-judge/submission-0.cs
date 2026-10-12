public class Solution {
    public int FindJudge(int n, int[][] trust) {
       int[] score = new int[n+1];

       foreach(int[] relation in trust){
            int person = relation[0];
            int trustedPerson = relation[1];

            score[person]--;
            score[trustedPerson]++;
        }

        for(int i = 1; i <= n; i++){
            if(score[i] == n-1) return i;
        }
        return -1;
    }
}