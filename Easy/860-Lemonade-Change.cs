public class Solution {
    public bool LemonadeChange(int[] bills) {
        int five=0;
        int ten=0;
        for(int i=0;i<bills.Length;i++){
            
            if(bills[i]==10){
                if(five==0){
                    return false;
                }
                five--;
                ten++;
            }
            else if(bills[i]==20){

                if(ten>=1 && five>=1){
                    ten--;
                    five--;
                }
                else if(five>=3){
                    five-=3;
                }
                else{
                    return false;
                }
            }
            else if(bills[i]==5){
                five++;
            }
            else{
                return false;
            }

        }
        return true;
    }
}
