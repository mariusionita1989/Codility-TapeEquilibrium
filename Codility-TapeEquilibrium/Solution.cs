using System.Runtime.CompilerServices;

namespace Codility_TapeEquilibrium
{
    public class Solution
    {
        private const int RANGE_LOWEST_VALUE = 2;
        private const int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int minDiff = int.MaxValue;
            if (A.Length >= RANGE_LOWEST_VALUE && A.Length <= RANGE_HIGHEST_VALUE) 
            {
                int totalSum = 0;
                int leftSum = 0;
                int rightSum;


                // Calculate the total sum of the array
                foreach (int num in A)
                    totalSum += num;

                for (int p = 1; p < A.Length; p++)
                {
                    leftSum += A[p - 1];
                    rightSum = totalSum - leftSum;
                    int diff = Math.Abs(leftSum - rightSum);

                    if (diff < minDiff)
                        minDiff = diff;
                }
            }
            return minDiff;
        }
    }
}
