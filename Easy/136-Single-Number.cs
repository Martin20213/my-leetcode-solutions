public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        for(int i=nums.Length-1;i>=0;i--){
            if(!seen.Contains(nums[i])){
                seen.Add(nums[i]);
            }
            else{
                seen.Remove(nums[i]);
            }
        }
        return seen.First();
    }
}