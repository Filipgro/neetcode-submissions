public class LRUCache {
    private List<KeyValuePair<int,int>> cache;
    private int capacity;

    public LRUCache(int capacity) {
        this.cache = new List<KeyValuePair<int, int>>();
        this.capacity=capacity;
    }
    
    public int Get(int key) {
        for(int i=0; i<cache.Count;i++){
            if(cache[i].Key==key){
                //swapping to correctly adjust LRU while return wanted value
                var temp = cache[i];
                cache.RemoveAt(i);
                cache.Add(temp);

                return temp.Value;
            }
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        for(int i=0; i<cache.Count;i++){
            //key exist remove and add new value on the same key so it becomes LRU
            if(cache[i].Key==key){
                cache.RemoveAt(i);
                cache.Add(new KeyValuePair<int,int>(key,value));
                return;
            }
        }
        //else if cap is full we remove MRU and add the new as LRU
        if(cache.Count==capacity){
            cache.RemoveAt(0);

        }
        cache.Add(new KeyValuePair<int,int>(key,value));
    }
}
