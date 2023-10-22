public class Solution {
    public int NumberOfSteps(int num) {
        int step = 0;
        while(num > 0)
        {
            if(num % 2 == 1)
            {
                num -= 1;
                step += 1;
            }
            else
            {
                num /= 2;
                step += 1;
            }
        }

        return step;
    }
}