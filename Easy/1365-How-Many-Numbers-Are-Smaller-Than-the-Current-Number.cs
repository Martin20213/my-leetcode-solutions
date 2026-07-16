public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] ans= new int[nums.Length];
        for(int i=0;i<nums.Length;i++){
            int countlower=0;
            for(int j=0;j<nums.Length;j++){
                if(nums[i]>nums[j]){
                    countlower++;
                }
            }
            ans[i]=countlower;
        }
        return ans;
    }
}