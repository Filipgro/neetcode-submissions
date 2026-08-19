public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        foreach (int asteroid in asteroids) {
            bool survives = true;

            while (survives &&
                     asteroid < 0 &&
                     stack.Count > 0 &&
                     stack.Peek() > 0)
             {
                int top = stack.Peek();

                if(top<-asteroid){
                    stack.Pop();
                }
                else if(top==-asteroid){
                    stack.Pop();
                    survives=false;
                }
                else{
                    survives=false;
                }
            }
            if(survives){
                stack.Push(asteroid);
            }
        }
        int[] res=new int[stack.Count];
        for(int i=res.Length-1;i>=0;i--){
            res[i]=stack.Pop();
        }
        return res;
    }
}