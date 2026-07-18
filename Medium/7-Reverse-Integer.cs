public class Solution {
    public int Reverse(int x) {
        int reverse=0;
        int digit=0;
        while(x!=0){
            digit = x%10;
                if(reverse>int.MaxValue/10 || reverse<int.MinValue/10){
                    return 0;
                }
            reverse = reverse*10+digit;
            x/=10;
        }
        return reverse;
    }
}