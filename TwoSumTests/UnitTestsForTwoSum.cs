using TwoSumLib;

namespace TwoSumTests
{
    public class UnitTestsForTwoSum
    {
        [Fact]
        public void Test1()
        {
            int[] testNumbers = { 2, 7, 11, 15};
            int target = 9;
            int[] expected = {0, 1};
            int[] actual = new int[2];

            TwoSumSolver solution = new();
            actual = solution.TwoSum(testNumbers, target);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            int[] testNumbers = { 3, 2, 4};
            int target = 6;
            int[] expected = { 1, 2 };
            int[] actual = new int[2];

            TwoSumSolver solution = new();
            actual = solution.TwoSum(testNumbers, target);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            int[] testNumbers = { 3, 3};
            int target = 6;
            int[] expected = { 1, 0 };
            int[] actual = new int[2];

            TwoSumSolver solution = new();
            actual = solution.TwoSum(testNumbers, target);

            Assert.Equal(expected, actual);
        }
    }
}