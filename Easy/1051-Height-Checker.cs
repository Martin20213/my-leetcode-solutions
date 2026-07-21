public class Solution {
    public int HeightChecker(int[] heights) {
        int indices = 0;
        int[] expected = (int[])heights.Clone();
        Array.Sort(expected);

        for(int i = 0; i < heights.Length; i++) {
            if(expected[i] != heights[i]) {
                indices++;
            }
        }

        return indices;
    }
}
