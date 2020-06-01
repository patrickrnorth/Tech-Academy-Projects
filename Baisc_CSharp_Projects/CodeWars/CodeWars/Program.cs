using System;

namespace CodeWars
{
    class FirstNonConsecutive
    {
        public static object firstNonConsecutive(int[] arr)
        {
            int[] myArray = { 1,2,3,4,6,9};      
            
            for (int i = 0; i < arr.Length && arr[i + 1] != arr.Length; i++)
            {
                if (arr[i + 1] != arr[i] + 1)
                {
                    return arr[i + 1];
                }
            }
            return null;
        }
    }
}
