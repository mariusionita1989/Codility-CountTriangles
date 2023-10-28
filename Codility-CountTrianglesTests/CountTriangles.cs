using Codility_CountTriangles;

namespace Codility_CountTrianglesTests
{
    public class SolutionTests
    {
        [Fact]
        public void Test_Solution_Example()
        {
            Solution solution = new Solution();
            int[] A = { 10, 2, 5, 1, 8, 12 };
            int expected = 4;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_NoTriplets()
        {
            Solution solution = new Solution();
            int[] A = { 1, 2, 3, 4, 5, 6 };
            int expected = 7;
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_AllTriplets()
        {
            Solution solution = new Solution();
            int[] A = { 3, 3, 3, 3, 3, 3 };
            int expected = 20; // All combinations of 3 elements are triangular
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_EmptyArray()
        {
            Solution solution = new Solution();
            int[] A = { };
            int expected = 0; // No triplets in an empty array
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_LowerBound()
        {
            Solution solution = new Solution();
            int[] A = { 1 };
            int expected = 0; // Not enough elements to form a triplet
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_Solution_UpperBound()
        {
            Solution solution = new Solution();
            int[] A = new int[1000]; 
            int expected = 0; // Number of valid triplets for this input
            int result = solution.solution(A);
            Assert.Equal(expected, result);
        }
    }
}