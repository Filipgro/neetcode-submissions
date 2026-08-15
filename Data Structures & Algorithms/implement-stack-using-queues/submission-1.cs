public class MyStack {
    private Queue<int> queue;
    public MyStack() {
        queue=new Queue<int>();
    }
    
    public void Push(int x) {
        queue.Enqueue(x);
    }
    
    public int Pop() {
        for(int i=0;i<queue.Count-1;i++){
            int q=queue.Dequeue();
            queue.Enqueue(q);
        }
        return queue.Dequeue();
    }
    
    public int Top() {
        for(int i=0;i<queue.Count-1;i++){
            int q=queue.Dequeue();
            queue.Enqueue(q);
        }
        int result = queue.Peek();
        int rotation=queue.Dequeue();
        queue.Enqueue(rotation);
        return result;
    }
    
    public bool Empty() {
        return queue.Count==0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */