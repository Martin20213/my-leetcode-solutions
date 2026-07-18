public class Solution {
    public long SumAndMultiply(int n) {
        string ans="";
        int sum=0;
        string nstring=n.ToString();
        for(int i=0;i<nstring.Length;i++){
            if(nstring[i]!='0'){
                ans+=nstring[i];
                sum+=nstring[i]-'0';
            }
        }
        if(ans == "")return 0;
        long ansnum = long.Parse(ans);
        return ansnum*sum;
    }
}