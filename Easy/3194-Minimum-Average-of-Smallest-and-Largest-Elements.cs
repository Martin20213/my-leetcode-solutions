public class Solution {
    public double MinimumAverage(int[] nums) {
        List<int> list = new List<int>(nums);
        double[] averages = new double[(nums.Length/2)];
        for(int i=0;i<averages.Length;i++){
        int max=int.MinValue;
        int min=int.MaxValue;
        for(int j=0;j<list.Count;j++){
            if(list[j]>max){
                max=list[j];
            }
            if(list[j]<min){
                min=list[j];
            }
        }
            averages[i]=(min+max)/2.0;
            list.Remove(min);
            list.Remove(max);
        }
        return averages.Min();
    }
}
