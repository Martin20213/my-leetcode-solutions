public class Solution {
    public int[] ConcatWithReverse(int[] nums) {
        int[] ans= new int[(nums.Length*2)];
        for(int i=0;i<nums.Length;i++){
            ans[i]=nums[i];
        }
        int index = nums.Length;
        for(int i=nums.Length-1;i>=0;i--){
            ans[index]=nums[i];
            index++;
        }
        return ans;
    }
}