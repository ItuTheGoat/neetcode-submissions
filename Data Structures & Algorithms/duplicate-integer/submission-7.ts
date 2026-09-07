class Solution {
    /**
     * @param {number[]} nums
     * @return {boolean}
     */
    hasDuplicate(nums: number[]): boolean {
        let numSet: Set<number> = new Set();

        for(let i = 0; i < nums.length; i++){
            if(numSet.has(nums[i]) == true) return true;
            numSet.add(nums[i]);
        }

        return false;
    }
}
