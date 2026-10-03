public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int one = 100;
        int two = 100;
        for(int i = 0; i<prices.Length; i++){
            if(prices[i] < one){
                two = one;
                one = prices[i];
            } else if (prices[i] < two) {
                two = prices[i];
            }
        }
        int res = money - (one+two);
        if(res >= 0){
            return res;
        }
        return money;
    }
}