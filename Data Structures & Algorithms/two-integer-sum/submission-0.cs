public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> result = new List<int>();

        for(int i = 0; i < nums.Length; i ++) {
            for(int j = nums.Length - 1; j > i; j--) {
                if(nums[i] + nums[j] == target) {
                    result.Add(i);
                    result.Add(j);
                } 
            }
        }

        return result.ToArray();
    }


}
