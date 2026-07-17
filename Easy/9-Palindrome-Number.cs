public class Solution {
    public bool IsPalindrome(int x) {
        string xPalindrome = x.ToString();
        string reverse="";
        for(int i=xPalindrome.Length-1;i>=0;i--){
            reverse+=xPalindrome[i];
        }
        if(xPalindrome==reverse){
            return true;
        }
        return false;
    }
}