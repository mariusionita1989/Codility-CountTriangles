using System.Runtime.CompilerServices;

namespace Codility_CountTriangles
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 1000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            Array.Sort(A); // Sort the input array
            int count = 0;
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                for (int i = 0; i < N - 2; i++)
                {
                    int k = i + 2;
                    for (int j = i + 1; j < N - 1; j++)
                    {
                        // Use binary search to find the index k such that A[i] + A[j] > A[k]
                        while (k < N && A[i] + A[j] > A[k])
                            k++;
                        // The number of triplets that can be formed with A[i] and A[j] is k - j - 1
                        count += k - j - 1;
                    }
                }
            }

            if(count<0)
                count = 0;

            return count;
        }
    }
}
