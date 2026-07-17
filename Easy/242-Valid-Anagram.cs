public class Solution {
    public bool IsAnagram(string s, string t) {
    
    if(s.Length!=t.Length)return false;

    Dictionary<char,int> count = new Dictionary<char,int>();
 
    foreach(char i in s){
        if(count.ContainsKey(i)){
            count[i]++;
        }
        else{
            count[i]=1;
        }
    }

    foreach(char i in t){
        if(!count.ContainsKey(i)){
            return false;
        }
        count[i]--;

        if(count[i]<0){
            return false;
        }
    }
    return true;
}
}