public class Solution {
    public bool CheckValid(int[][] matrix) {
        int length=matrix.Length;
        
        for(int i=0;i<length;i++){
            HashSet<int> row = new HashSet<int>();
            for(int j=0;j<length;j++){
                if(row.Contains(matrix[i][j])){
                    return false;
                }
                row.Add(matrix[i][j]);
            }
            if(row.Count!=length){
                return false;
            }
        }

        for(int i=0;i<length;i++){
            HashSet<int> col = new HashSet<int>();
            for(int j=0;j<length;j++){
                if(col.Contains(matrix[j][i])){
                    return false;
                }
                col.Add(matrix[j][i]);
            }
            if(col.Count!=length){
                return false;
            }
        }
        return true;
    }
}
