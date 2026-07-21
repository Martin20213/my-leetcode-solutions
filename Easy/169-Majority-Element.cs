public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> answer = new Dictionary<int,int>();
        int element = 0;
        for(int i=0;i<nums.Length;i++){
            if(answer.ContainsKey(nums[i])){
                answer[nums[i]]++;
            }else{
                answer.Add(nums[i],1);
            }
        }
        foreach(var item in answer){
            if(item.Value > nums.Length/2){
                return element = item.Key;
            }
        }
        return element;
    }
}
