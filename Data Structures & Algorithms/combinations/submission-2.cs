public class Solution {
    public List<List<int>> Combine(int n, int k) {
        List<List<int>> res = new List<List<int>>();
        Combinations(1,new List<int>(), res, n,k);
        return res;
    }
    private void Combinations(int i,List<int> curr,List<List<int>> res, 
                              int n, int k)
    {
        if(curr.Count==k){
            res.Add(new List<int>(curr));
            return;
        }
        if(i>n){
            return;
        }
        for(int j = i; j<n+1;j++){
            curr.Add(j);
            Combinations(j+1,curr,res,n,k);
            curr.RemoveAt(curr.Count-1);
        }
    }
}