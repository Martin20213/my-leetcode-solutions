public class Solution {
    public int[] FindDegrees(int[][] matrix) {
        int n = matrix.Length;
        int[] ans = new int[n];
        
        for(int i=0;i<n;i++){
            int sum=0;
            for(int j=0;j<n;j++){
                if(matrix[i][j]==1){
                    sum++;
                }
            }
            ans[i]=sum;
        }
        return ans;
    }
}