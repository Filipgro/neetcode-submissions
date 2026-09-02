public class Solution {
    public int LastStoneWeight(int[] stones) {
        int x=0;
        int y=0;
        PriorityQueue<int,int> maxheap=new PriorityQueue<int,int>();
        foreach(int s in stones){
            maxheap.Enqueue(s,-s);
        }
        while(maxheap.Count>=2){
            x=maxheap.Dequeue();
            y=maxheap.Dequeue();
            if(x-y!=0){
                maxheap.Enqueue(x-y,y-x);
            }
        }
        if(maxheap.Count==1){
            return maxheap.Peek();
        }
        return 0;
    }
}
