public class Solution {
    public int CalPoints(string[] operations) {
        List<int> ops = new List<int>();
        int sum=0;
        for(int i=0;i<operations.Length;i++){
            if(operations[i]=="C"){
                ops.RemoveAt(ops.Count-1);
            }
            else if(operations[i]=="D"){
                ops.Add(ops[ops.Count - 1] * 2);
            }
            else if(operations[i]=="+"){
                ops.Add(
                    ops[ops.Count - 1] + 
                    ops[ops.Count - 2]
                );
            }
            else{
            ops.Add(int.Parse(operations[i]));
            }
        }
        if(ops.Count!=0){
            return ops.Sum();
        }
        return 0;   
    }
}
