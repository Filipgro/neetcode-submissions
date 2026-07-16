public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int left = 0;
       int right = matrix.Length * matrix[0].Length - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            int midValue = matrix[mid / matrix[0].Length][mid % matrix[0].Length];
            if (midValue == target)
            {
                return true;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return false;
    }
}
