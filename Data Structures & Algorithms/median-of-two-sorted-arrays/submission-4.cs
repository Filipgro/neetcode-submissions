public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length){
            (nums1, nums2) = (nums2, nums1);
        }
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int total = n1 + n2;
        int half = total / 2;

        int l = 0, r = n1;

        while (l <= r) {
            int i = (l + r) / 2;     
            int j = half - i;          

            int aLeft  = (i == 0)     ? int.MinValue : nums1[i - 1];
            int aRight = (i == n1)    ? int.MaxValue : nums1[i];
            int bLeft  = (j == 0)     ? int.MinValue : nums2[j - 1];
            int bRight = (j == n2)    ? int.MaxValue : nums2[j];

            if (aLeft <= bRight && bLeft <= aRight) {
                if (total % 2 == 1) {
                    return Math.Min(aRight, bRight);
                }
                return (Math.Max(aLeft, bLeft) + Math.Min(aRight, bRight)) / 2.0;
            }

            if (aLeft > bRight) {
                r = i - 1;
            } else {
                l = i + 1;
            }
        }

        return 0; 
    }
}
