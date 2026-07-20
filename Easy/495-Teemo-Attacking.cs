public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int seconds = duration;
        for(int i=0; i<timeSeries.Length-1; i++){
            if(duration>(timeSeries[i+1]-timeSeries[i])){
                seconds+=(timeSeries[i+1]-timeSeries[i]);
            }else{
                seconds+=duration;
            }
        }
    return seconds;
    }
}
