public class Solution {
    public bool hasDuplicate(int[] nums) {
        var result = false;
        // sort first
        Array.Sort(nums);

        // start at 1
        for(int i = 1; i < nums.Length; i++) {
            var resultVal = isDuplicate(nums[i - 1], nums[i]);
            if(resultVal == true) {
                result = true;
            }
        }

        return result;
    }

    bool isDuplicate(int previousValue, int currentValue) {
        if(previousValue == currentValue) {
            return true; 
        } else {
            return false;
        }
    }
}