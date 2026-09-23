public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        dfs(0,candidates,target,new List<int>(),0);
        return res;
    }
    private void dfs(int i, int[] candidates, int target, List<int> cur, int total){
        if(total==target){
            res.Add(new List<int>(cur));
            return;
        }
        if(total > target || i == candidates.Length){
            return;
        }
        // include candidates[i]
        cur.Add(candidates[i]);
        dfs(i+1, candidates,target,cur,total+candidates[i]);
        cur.RemoveAt(cur.Count-1);

        //skip candidates[i]
        while( i+1<candidates.Length && candidates[i]==candidates[i+1]){
            i++;
        }
        dfs(i+1, candidates,target,cur,total);
    }
}
