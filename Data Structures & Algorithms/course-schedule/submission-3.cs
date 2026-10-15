public class Solution {
    private  Dictionary<int,List<int>> map = new Dictionary<int,List<int>>();
    private HashSet<int> visit = new HashSet<int>();
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        for(int i = 0; i < numCourses; i++){
            map[i] = new List<int>();
        }

        foreach(int[] pre in prerequisites){
            map[pre[0]].Add(pre[1]);
        }

        for(int i = 0; i < numCourses; i++){
            if(!Dfs(i)) return false;
        }

        return true;
    }
    private bool Dfs(int crs){
        if(visit.Contains(crs)) return false;
        if(map[crs].Count == 0) return true;
        
        visit.Add(crs);
        foreach(int pre in map[crs]){
            if(!Dfs(pre)) return false;
        }
        visit.Remove(crs);
        map[crs].Clear();
        return true;
    }
}
