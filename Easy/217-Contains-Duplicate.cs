public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new HashSet<int>();
        for(int i=0;i<nums.Length;i++){
            if(!seen.Contains(nums[i])){
                seen.Add(nums[i]);
            }
            else{
                return true;
            }
        }
        return false;
    }
}