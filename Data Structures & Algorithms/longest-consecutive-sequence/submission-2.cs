    public class Solution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> result = new HashSet<int>();
            foreach(int num in nums)
            {
                result.Add(num);
            }
        int longestStreak = 0;
        for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (!result.Contains(current - 1))
                {
                    int CurrentStreakLength = 1;
                while (result.Contains(current + 1))
                {
                    current++;
                    CurrentStreakLength++;
                }
                longestStreak = Math.Max(longestStreak, CurrentStreakLength);
                }
            }
            return longestStreak;
        }
    }
