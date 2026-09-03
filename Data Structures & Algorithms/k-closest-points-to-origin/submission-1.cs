public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], int> maxheap = new PriorityQueue<int[], int>();
        for (int i = 0; i < points.Length; i++) {
            int x = points[i][0];
            int y = points[i][1];
            int distance = x * x + y * y;
            maxheap.Enqueue(points[i], -distance);
            if (maxheap.Count > k) {
                maxheap.Dequeue();
            }
        }
        int[][] res = new int [k][];
        for (int i = 0; i < k; i++) {
            res[i] = maxheap.Dequeue();
        }
        return res;
    }
}
