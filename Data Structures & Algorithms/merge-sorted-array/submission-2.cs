public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for(int i = 0; i < n; i++){
            nums1[m+n-1-i] = nums2[i];
        }
        Array.Sort(nums1);
    }
}