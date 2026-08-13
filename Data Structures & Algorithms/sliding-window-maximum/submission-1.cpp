class Solution {
public:
    vector<int> maxSlidingWindow(vector<int>& nums, int k) {
        priority_queue<int> pq;
        unordered_map<int,int> freq;
        for(int i=0;i<k;i++){
            pq.push(nums[i]);
            freq[nums[i]]++;
        }

        vector<int> res;
        int l=0;
        int r=k-1;
        for(int i=0;i<nums.size()-k;i++)
        {
            int top = pq.top();
            while(freq[top] <=0)
            {
                pq.pop();
                top = pq.top();
            }

            res.push_back(top);

            freq[nums[l]]--;
            l++;
            r++;
            freq[nums[r]]++;
            pq.push(nums[r]);
        }

        int top = pq.top();
            while(freq[top] <=0)
            {
                pq.pop();
                top = pq.top();
            }

        res.push_back(top);


        return res;
    }
};
