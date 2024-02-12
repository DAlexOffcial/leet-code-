using System;

namespace CodeWars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] Array = { 2, 4, 11, 3 };
            int target = 6;
            TwoSum(Array, target);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }

            return result;
        }

        /*mejor solucion :
        public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int x = 0; x < nums.Length; x++)
        {
             for(int y = x + 1; y < nums.Length; y++)
             {
                    if(nums[x] + nums[y] == target) return new int[]{x, y};
             }
        }
        return null;
    }
}
        */
    }
}