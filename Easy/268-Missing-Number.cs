public class Solution {
    public int MissingNumber(int[] nums) {

        Array.Sort(nums);

        if(nums.Length==0){
            return 0;
        }
        if(nums[0]!=0){
            return 0;
        }

        for(int i=1;i<nums.Length;i++){
            if((nums[i])!=nums[i-1]+1){
                return nums[i]-1;
            }
        }
        return nums.Length;
    }
}
