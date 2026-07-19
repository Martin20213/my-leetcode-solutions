public class Solution {
    public int[] RecoverOrder(int[] order, int[] friends) {
        int[] ans= new int[friends.Length];
        int index=0;
            for(int i=0;i<order.Length;i++){
                for(int j=0;j<friends.Length;j++){
                    if(order[i]==friends[j]){
                        ans[index]=order[i];
                        index++;
                    }
                }
            }
        return ans;
    }
}