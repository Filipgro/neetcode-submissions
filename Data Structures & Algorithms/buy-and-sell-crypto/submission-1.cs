public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit=0;
        int left=0;
        int right= 1;
        while(right<prices.Length){
            if(prices[left]<prices[right]){
                int curProfit=prices[right]-prices[left];
                if(curProfit>maxProfit){
                    maxProfit=curProfit;
                }
            }
            else{
                left=right;
            }
            right++;
        }
        return maxProfit;
    }
}
