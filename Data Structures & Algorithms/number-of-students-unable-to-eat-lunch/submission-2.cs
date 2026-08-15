public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        int count0=0;
        int count1=0;
        foreach(int s in students){
            if(s==0){
                count0++;
            }else{
                count1++;
            }
        }
        
        Queue<int> queue=new Queue<int>();
        foreach(int st in students){
            queue.Enqueue(st);
        }

        Stack<int> sandvichi=new Stack<int>();
        for(int i=sandwiches.Length-1;i>=0;i--){
            sandvichi.Push(sandwiches[i]);
        }
        
        while (queue.Count > 0 &&
             ((sandvichi.Peek() == 0 && count0 > 0) ||
             (sandvichi.Peek() == 1 && count1 > 0))){
            int student=queue.Dequeue();
            if(student==sandvichi.Peek()){
                sandvichi.Pop();
                if(student==0){
                    count0--;
                }else{
                    count1--;
                }
            }else{
                queue.Enqueue(student);
            }
        }
        return queue.Count;
    }
}