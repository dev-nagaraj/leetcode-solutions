/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement)) {
                return new int[] { dict[complement], i };
            }
            dict[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
        
    }
}
// @lc code=end

