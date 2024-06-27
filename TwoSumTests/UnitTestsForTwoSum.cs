using TwoSum_Solver;
using Xunit.Sdk;

namespace TwoSum_Tests;

public class UnitTestsForTwoSum
{
    private readonly IEnumerable<object> DataForUnitTests = new List<object>
    {
         new object[] {new[] { 2, 7, 11, 15 }, new[] { 0, 1 }, 9 },
         new object[] {new[] { 2, 7, 11, 15 }, new[] { 0, 1 }, 9 },
    };


    [Theory]
    [MemberData(nameof(DataForUnitTests))]

    public void UnitTestForSolverByEqualistaion(int[] numbers, int[] expected, int target)
    {
        Solver solver = new Solver();
        int[] actual = new int[2];

        actual = solver.TwoSum(numbers, target);

        Assert.Equal(expected, actual);
    }
}