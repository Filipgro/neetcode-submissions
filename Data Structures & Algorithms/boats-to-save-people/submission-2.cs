public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
     Array.Sort(people);
     int boats=0;
     int l=0;
     int r=people.Length-1;
     while(l<=r){
        if(people[l]+people[r]>limit){
            r--;
            boats++;
        }else if (l < r){
            l++;
            r--;
            boats++;
        }else{
            l++;
            boats++;
        }
     }
     return boats;
    }
}