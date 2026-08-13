class Solution {
    bool is_lower(char a)
    {
        return 'a'<= a && a<='z';
    }
public:
    string minWindow(string s, string t) {
        vector<int> inputFrq(54, 0);
        vector<int> runningFrq(54, 0);

        for(auto c: t){
            if(is_lower(c))
                inputFrq[c-'a']++;
            else{
                inputFrq[c-'A'+27]++;
            }

        }


        int l=0;
        int r= 0;
        pair<int,int> view;
        int ans = INT_MAX;
        while(r!=s.size())
        {   
            char c = s[r];
            if(is_lower(c))
                runningFrq[c-'a']++;
            else{
                runningFrq[c-'A'+27]++;
            }

            while(l<=r)
            {
                bool okey = true;
                for(int i=0;i<54;i++){
                    if(inputFrq[i]!=0 && runningFrq[i]<inputFrq[i])
                        okey = false;
                    }

                if(!okey)
                    break;
                if(ans > r-l+1)
                {
                    ans = r-l+1;
                    view = {l, r};
                }
                char c = s[l];
                if(is_lower(c))
                    runningFrq[c-'a']--;
                else{
                    runningFrq[c-'A'+27]--;
                }
                l++;
                
            }

            r++;
        }

        cout<<ans<<" "<<view.first<<" "<<view.second;

        if(ans==INT_MAX)
            return "";

        return string{s.begin()+view.first, s.begin()+view.second+1};
    }
};
