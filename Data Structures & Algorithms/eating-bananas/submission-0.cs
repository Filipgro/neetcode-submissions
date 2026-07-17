public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();
        int res = right;
        while (left <= right)
        {
            int k = left + (right - left) / 2;
            double hours = 0;
            foreach (int pile in piles)
            {
                hours += Math.Ceiling((double)pile / k);
            }
            if (hours <= h)
            {
                res = Math.Min(res, k);
                right = k - 1;
            }
            else
            {
                left = k + 1;
            }
        }
        return res; 
    }
}
