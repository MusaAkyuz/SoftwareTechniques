public class Solution {
    public bool IsPalindrome(int x) {
        var numberStr = Convert.ToString(x);
        for(var i = 0; i<numberStr.Length/2; i++)
        {
            if(numberStr[i] != numberStr[numberStr.Length-1-i])
            {
                return false;
            }
        }
        return true;
    }
}