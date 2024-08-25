// https://leetcode.com/problems/two-sum/

int[] TwoSum(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {

                if (nums[i] + nums[j] == target)
                {
                return [i, j];
                }
            }
        }

        return nums;
    }

var res = TwoSum([1, 2, 3], 4);

if (!res.SequenceEqual([0, 2])) throw new Exception("Epic fail");