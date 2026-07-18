public class Solution {
    public int FindGCD(int[] nums) {
        int min=int.MaxValue;
        int max=int.MinValue;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]>max){
                max=nums[i];
            }
            if(nums[i]<min){
                min=nums[i];
            }
        }
        int temp=0;
        while(max!=0){
            temp=max;
            max=min%max;
            min=temp;
        }
        return min;
    }
}
