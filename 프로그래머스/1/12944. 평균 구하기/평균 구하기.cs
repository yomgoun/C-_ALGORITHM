public class Solution {
    public double solution(int[] arr) {
       double answer = 0;
      int count = 0;
        for(int i = 0; i < arr.Length; i++)
        {
           answer += arr[i];
           count ++;    
        }
        return answer/count;
    }
}