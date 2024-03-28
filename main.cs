public class Solution {
    public bool CanJump(int[] nums) 
    {
        int size = nums.Count();
        int i = 0;
        for(int reach = 0; i < size && i <= reach; ++i)
        {
            reach = ((i + nums[i]) > reach ? (i + nums[i]) : reach);
        }
        return i == size;
    }
}
