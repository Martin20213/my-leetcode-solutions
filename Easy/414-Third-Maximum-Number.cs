public class Solution {
    public int ThirdMax(int[] nums) {
        long maxfirst = long.MinValue;
        long maxsecond = long.MinValue;
        long maxthird = long.MinValue;

        for(int i=0;i<nums.Length;i++){

            if (nums[i] == maxfirst || nums[i] == maxsecond || nums[i] == maxthird)
            continue;

            if(nums[i]>maxfirst){
                maxthird=maxsecond;
                maxsecond=maxfirst;
                maxfirst=nums[i];
            }
            else if(nums[i]>maxsecond){
                maxthird=maxsecond;
                maxsecond=nums[i];
            }
            else if(nums[i]>maxthird){
                maxthird=nums[i];
            }
        }

        if(maxthird == long.MinValue){
            return (int)maxfirst;
        }
        return (int)maxthird;
    }
}