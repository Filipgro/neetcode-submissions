public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int,int> minheap = new PriorityQueue<int,int>();
        foreach(int num in nums){
            minheap.Enqueue(num,num);
            if(minheap.Count>k){
                minheap.Dequeue();
            }
        }
        return minheap.Peek();
    }
}
