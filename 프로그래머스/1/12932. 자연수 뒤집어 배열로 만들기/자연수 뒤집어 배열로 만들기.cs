using System;
using System.Linq;

public class Solution {
    public int[] solution(long n) {
        
        string temp = n.ToString();
        
        int[] answer = new int[temp.Length];
        
        for(int i = 0; i < temp.Length; i++) { answer[i] = int.Parse(temp[i].ToString());}
        
        Array.Reverse(answer);
        
        return answer;
    }
}