namespace TwoSumLib;
public class TwoSumSolver
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] resultingArray = new int[2];

        for (int pivotIndex = 0; pivotIndex < nums.Length; pivotIndex++)
        {

            int pairIndex = Array.IndexOf(nums, target - nums[pivotIndex]);

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