public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int length=nums.Length;
        int[] answer = new int[length*2];
        for(int i=0;i<length;i++){
            answer[i]=nums[i];
            answer[length+i]=nums[i];
        }
        return answer;
    }
}
