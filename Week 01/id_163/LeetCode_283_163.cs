public class Solution {
    public void MoveZeroes(int[] nums) {
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
                if (nums[j] != 0)
                {
                    if (i != j)
                    {
                        nums[i] = nums[j];
                    }
                    i++;
                }
            
            for (; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
