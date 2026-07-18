public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int length = nums.Length;
        int index=1;
        for(int i=1;i<length;i++){
            if(nums[i]!=nums[i-1]){
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
}