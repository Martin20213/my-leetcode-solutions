public class Solution {
    public int CountSeniors(string[] details) {
        int ans=0;
        for(int i=0;i<details.Length;i++){
            if(details[i][11]>'6' || details[i][11]=='6' && details[i][12]>'0'){
                ans++;
            }
        }
        return ans;
    }
}