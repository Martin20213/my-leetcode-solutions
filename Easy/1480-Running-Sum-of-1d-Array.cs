public class Solution {
    public int[] RunningSum(int[] nums) {
        int sum=nums[0];
        for(int i=1;i<nums.Length;i++){
            sum+=nums[i];
            nums[i]=sum;
        }
        return nums;
    }
}
