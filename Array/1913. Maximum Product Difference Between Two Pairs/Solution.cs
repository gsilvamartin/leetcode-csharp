public class Solution {
    public int MaxProductDifference(int[] nums) {
        Array.Sort(nums);

        return CalcProduct(nums[nums.Length - 1], nums[nums.Length - 2], nums[0], nums[1]);
    }

    public int CalcProduct(int a, int b, int c, int d){
        return (a * b) - (c * d);
    }
}
