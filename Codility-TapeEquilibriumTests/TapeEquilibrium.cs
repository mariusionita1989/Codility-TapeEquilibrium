using Codility_TapeEquilibrium;

namespace Codility_TapeEquilibriumTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestExampleInput()
        {
            Solution solution = new Solution();
            int[] A = { 3, 1, 2, 4, 3 };
            int expected = 1;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMinimumInput()
        {
            Solution solution = new Solution();
            int[] A = { 0, 0 };
            int expected = 0; // The tape can only be split at P=1, and the difference is 0.
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllNegativeInput()
        {
            Solution solution = new Solution();
            int[] A = { -1, -2, -3, -4, -5 };
            int expected = 3; // The optimal split is at P=3, resulting in a difference of 3.
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllPositiveInput()
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3, 4, 5 };
            int expected = 3; // The optimal split is at P=2, resulting in a difference of 3.
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}