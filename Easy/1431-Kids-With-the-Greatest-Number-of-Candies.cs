public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> greatest = new List<bool>();
        int maxcandies=0;
        for(int i=0;i<candies.Length;i++){
            if(maxcandies<candies[i]){
                maxcandies=candies[i];
            }
        }
        for(int i=0;i<candies.Length;i++){
            candies[i]=candies[i]+extraCandies;
            if(candies[i]>=maxcandies){
                greatest.Add(true);
            }else{
                greatest.Add(false);
            }
            candies[i]=candies[i]-extraCandies;
        }
        return greatest;
    }
}