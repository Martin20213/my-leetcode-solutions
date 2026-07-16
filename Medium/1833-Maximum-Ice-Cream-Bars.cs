public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        Array.Sort(costs);
        int sum=0;
        int count=0;
        for(int i=0;i<costs.Length;i++){
            if(sum+costs[i]<=coins){
                sum=sum+costs[i];
                count++;
            }
        }
        return count;
    }
}