public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var frequency= new Dictionary<int, int>();
        foreach(int n in nums)
        {
            if (frequency.ContainsKey(n))
            {
                frequency[n]++;
            }
            else
            {
                frequency[n] = 1;
            }
        }
        var sorted = frequency.OrderByDescending(pair => pair.Value);
        int[] result = new int[k];
        int i = 0;

        foreach (var pair in sorted)
        {
            result[i] = pair.Key;

            i++;

            if (i == k)
                break;
        }

        return result;
    }
}