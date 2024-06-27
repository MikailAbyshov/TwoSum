namespace TwoSum_Solver;

public class Solver
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] resultingArray = new int[2];

        for (var pivotIndex = 0; pivotIndex < nums.Length; pivotIndex++)
        {

            var pairIndex = Array.IndexOf(nums, target - nums[pivotIndex]);

            if (pairIndex >= 0 && pairIndex != pivotIndex)
            {
                resultingArray[0] = pivotIndex;
                resultingArray[1] = pairIndex;
                return resultingArray;
            }
        }
        return resultingArray;
    }
}