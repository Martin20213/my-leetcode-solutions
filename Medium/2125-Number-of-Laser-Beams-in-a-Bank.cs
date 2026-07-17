public class Solution {
    public int NumberOfBeams(string[] bank) {
        //count the lasers on each row
        List<int> rows = new List<int>();
        for(int i=0;i<bank.Length;i++){
            
            int rowsCount=0;  
            for(int j=0;j<bank[i].Length;j++){
                if(bank[i][j]=='1'){
                    rowsCount++;
                }
            }
            rows.Add(rowsCount);
        }
        //count the laserbeams
        int prev=0;
        int laserbeam=0;
        bool hasPrevious=false;
        for(int i=0;i<rows.Count;i++){
            if(prev==0 && rows[i]!=0){
                prev=rows[i];
            }
            if(prev!=0 && rows[i]!=0 && hasPrevious==true){
                laserbeam+=(prev*rows[i]);
                prev = rows[i];
            }
            if(prev!=0)hasPrevious=true;
        }
        return laserbeam;
    }
}