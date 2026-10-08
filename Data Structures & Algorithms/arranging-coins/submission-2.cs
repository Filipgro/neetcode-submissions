public class Solution {
    public int ArrangeCoins(int n) {
        long rows = (long)(Math.Sqrt((long)n*8+1)-1)/2;
        return (int)rows;
    }
}